using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using AxoCover.Common.Extensions;
using AxoCover.Common.Models;
using AxoCover.Common.Runner;
using AxoCover.Common.Settings;
using AxoCover.Models.Editor;
using AxoCover.Models.Testing.Data;
using EnvDTE;
using VSLangProj;

namespace AxoCover.Models.Testing.Adapters
{
  // TODO: create base class for xUnit adapters
  public class xUnitNetCoreAdapter : ITestAdapter
  {
    private readonly string _assemblyPath;
    private readonly string[] _redirectedAssemblies;
    private IEditorContext _context;
    private Regex _displayNameRegex = new Regex(@"(?>(?<path>[\w.]*))(?>(?<arguments>.+))");
    private Regex _fullyQualifiedNameRegex = new Regex(@"^(?>(?<path>[\w.]*) \(\w+\))$");

    public string Name => "xunit.net";

    public string ExecutorUri => "executor://xunit/VsTestRunnerDotNet";

    public TestAdapterMode Mode => TestAdapterMode.Standard;

    public bool CanProcessCase(TestCase testCase)
    {
      return testCase.ExecutorUri.ToString().Contains("xunit", StringComparison.OrdinalIgnoreCase);
    }

    public TestAdapterOptions GetLoadingOptions()
    {
      return new TestAdapterOptions()
      {
        AssemblyPath = _assemblyPath,
        RedirectedAssemblies = _redirectedAssemblies,
        RedirectionOptions = FileRedirectionOptions.ExcludeNonexistentDirectories | FileRedirectionOptions.ExcludeNonexistentFiles | FileRedirectionOptions.IncludeBaseDirectory,
        ExtensionUri = ExecutorUri
      };
    }

    public bool IsTestSource(Project project)
    {
      var references = (project.Object as VSProject)?.References.OfType<Reference>().Select(r => r.Name).Where(n => n.Contains("xunit")).ToList();
      return project.TryGetReference("xunit.runner.visualstudio.dotnetcore.testadapter", out _);
    }

    public void ProcessCase(TestCase testCase, ref CodeItemKind testItemKind, ref string testItemPath, ref string displayName)
    {
      var fullyQualifiedNameMatch = _fullyQualifiedNameRegex.Match(testCase.FullyQualifiedName);
      if (fullyQualifiedNameMatch.Success)
      {
        var displayNameMatch = _displayNameRegex.Match(testCase.DisplayName);
        if (displayNameMatch.Success)
        {
          testItemKind = CodeItemKind.Data;
          displayName = displayNameMatch.Groups["arguments"].Value;
          testItemPath = fullyQualifiedNameMatch.Groups["path"].Value + ".Instance" + testCase.Id.ToString("N");
        }
        else
        {
          testItemPath = fullyQualifiedNameMatch.Groups["path"].Value;
        }
      }
    }

    public xUnitNetCoreAdapter(IEditorContext editorContext)
    {
      _context = editorContext;
      _assemblyPath = @"G:\dev\lib-db-extensions-fastcrud\bin\debug\test\xunit.runner.visualstudio.dotnetcore.testadapter.dll"; ////Path.Combine(AxoCoverPackage.PackageRoot, @"xUnitAdapter\netcore\xunit.runner.visualstudio.dotnetcore.testadapter.dll");
      _redirectedAssemblies = Directory.GetFiles(Path.GetDirectoryName(_assemblyPath), "*.dll");
    }
  }
}
