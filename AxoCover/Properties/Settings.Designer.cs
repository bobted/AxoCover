﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AxoCover.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TestRunner {
            get {
                return ((string)(this["TestRunner"]));
            }
            set {
                this["TestRunner"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsShowingLineCoverage {
            get {
                return ((bool)(this["IsShowingLineCoverage"]));
            }
            set {
                this["IsShowingLineCoverage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute")]
        public string ExcludeAttributes {
            get {
                return ((string)(this["ExcludeAttributes"]));
            }
            set {
                this["ExcludeAttributes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ExcludeFiles {
            get {
                return ((string)(this["ExcludeFiles"]));
            }
            set {
                this["ExcludeFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ExcludeDirectories {
            get {
                return ((string)(this["ExcludeDirectories"]));
            }
            set {
                this["ExcludeDirectories"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("+[*]*")]
        public string Filters {
            get {
                return ((string)(this["Filters"]));
            }
            set {
                this["Filters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsShowingBranchCoverage {
            get {
                return ((bool)(this["IsShowingBranchCoverage"]));
            }
            set {
                this["IsShowingBranchCoverage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsShowingExceptions {
            get {
                return ((bool)(this["IsShowingExceptions"]));
            }
            set {
                this["IsShowingExceptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsShowingPartialCoverage {
            get {
                return ((bool)(this["IsShowingPartialCoverage"]));
            }
            set {
                this["IsShowingPartialCoverage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsIncludingSolutionAssemblies {
            get {
                return ((bool)(this["IsIncludingSolutionAssemblies"]));
            }
            set {
                this["IsIncludingSolutionAssemblies"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsExcludingTestAssemblies {
            get {
                return ((bool)(this["IsExcludingTestAssemblies"]));
            }
            set {
                this["IsExcludingTestAssemblies"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsCoveringByTest {
            get {
                return ((bool)(this["IsCoveringByTest"]));
            }
            set {
                this["IsCoveringByTest"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF008000")]
        public global::System.Windows.Media.Color CoveredColor {
            get {
                return ((global::System.Windows.Media.Color)(this["CoveredColor"]));
            }
            set {
                this["CoveredColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFFCC00")]
        public global::System.Windows.Media.Color MixedColor {
            get {
                return ((global::System.Windows.Media.Color)(this["MixedColor"]));
            }
            set {
                this["MixedColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFE51300")]
        public global::System.Windows.Media.Color UncoveredColor {
            get {
                return ((global::System.Windows.Media.Color)(this["UncoveredColor"]));
            }
            set {
                this["UncoveredColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF00FF00")]
        public global::System.Windows.Media.Color SelectedColor {
            get {
                return ((global::System.Windows.Media.Color)(this["SelectedColor"]));
            }
            set {
                this["SelectedColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFE51300")]
        public global::System.Windows.Media.Color ExceptionOriginColor {
            get {
                return ((global::System.Windows.Media.Color)(this["ExceptionOriginColor"]));
            }
            set {
                this["ExceptionOriginColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFFCC00")]
        public global::System.Windows.Media.Color ExceptionTraceColor {
            get {
                return ((global::System.Windows.Media.Color)(this["ExceptionTraceColor"]));
            }
            set {
                this["ExceptionTraceColor"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/axodox/AxoCover/issues")]
        public string IssuesUrl {
            get {
                return ((string)(this["IssuesUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("support+a55607fb8aa74170a9db076bb26bafd5@feedback.hockeyapp.net ")]
        public string FeedbackEmail {
            get {
                return ((string)(this["FeedbackEmail"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("b11224706abc4b7cb5bd5b70396ee7c3")]
        public string TelemetryKey {
            get {
                return ((string)(this["TelemetryKey"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00000000-0000-0000-0000-000000000000")]
        public global::System.Guid InstallationId {
            get {
                return ((global::System.Guid)(this["InstallationId"]));
            }
            set {
                this["InstallationId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsTelemetryEnabled {
            get {
                return ((bool)(this["IsTelemetryEnabled"]));
            }
            set {
                this["IsTelemetryEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsTelemetryModeSelected {
            get {
                return ((bool)(this["IsTelemetryModeSelected"]));
            }
            set {
                this["IsTelemetryModeSelected"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/axodox/AxoCover")]
        public string SourceCodeUrl {
            get {
                return ((string)(this["SourceCodeUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("x86")]
        public global::AxoCover.Common.Settings.TestPlatform TestPlatform {
            get {
                return ((global::AxoCover.Common.Settings.TestPlatform)(this["TestPlatform"]));
            }
            set {
                this["TestPlatform"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("STA")]
        public global::AxoCover.Common.Settings.TestApartmentState TestApartmentState {
            get {
                return ((global::AxoCover.Common.Settings.TestApartmentState)(this["TestApartmentState"]));
            }
            set {
                this["TestApartmentState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TestSettings {
            get {
                return ((string)(this["TestSettings"]));
            }
            set {
                this["TestSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsMergingByHash {
            get {
                return ((bool)(this["IsMergingByHash"]));
            }
            set {
                this["IsMergingByHash"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsSkippingAutoProps {
            get {
                return ((bool)(this["IsSkippingAutoProps"]));
            }
            set {
                this["IsSkippingAutoProps"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Standard")]
        public global::AxoCover.Common.Settings.TestAdapterMode TestAdapterMode {
            get {
                return ((global::AxoCover.Common.Settings.TestAdapterMode)(this["TestAdapterMode"]));
            }
            set {
                this["TestAdapterMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[]")]
        public string ReleaseListCache {
            get {
                return ((string)(this["ReleaseListCache"]));
            }
            set {
                this["ReleaseListCache"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("09/02/2016 20:41:51")]
        public global::System.DateTime ReleaseListUpdateTime {
            get {
                return ((global::System.DateTime)(this["ReleaseListUpdateTime"]));
            }
            set {
                this["ReleaseListUpdateTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[]")]
        public string ReleaseRollbackList {
            get {
                return ((string)(this["ReleaseRollbackList"]));
            }
            set {
                this["ReleaseRollbackList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ReleaseBranch {
            get {
                return ((string)(this["ReleaseBranch"]));
            }
            set {
                this["ReleaseBranch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsUpdatingAutomatically {
            get {
                return ((bool)(this["IsUpdatingAutomatically"]));
            }
            set {
                this["IsUpdatingAutomatically"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Version ReleaseInstalled {
            get {
                return ((global::System.Version)(this["ReleaseInstalled"]));
            }
            set {
                this["ReleaseInstalled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsRedirectingFrameworkAssemblies {
            get {
                return ((bool)(this["IsRedirectingFrameworkAssemblies"]));
            }
            set {
                this["IsRedirectingFrameworkAssemblies"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Tcp")]
        public global::AxoCover.Common.Extensions.CommunicationProtocol TestProtocol {
            get {
                return ((global::AxoCover.Common.Extensions.CommunicationProtocol)(this["TestProtocol"]));
            }
            set {
                this["TestProtocol"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int StartupTimeout {
            get {
                return ((int)(this["StartupTimeout"]));
            }
            set {
                this["StartupTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int DebuggerTimeout {
            get {
                return ((int)(this["DebuggerTimeout"]));
            }
            set {
                this["DebuggerTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsDebugModeEnabled {
            get {
                return ((bool)(this["IsDebugModeEnabled"]));
            }
            set {
                this["IsDebugModeEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsVisitorRecordLimited {
            get {
                return ((bool)(this["IsVisitorRecordLimited"]));
            }
            set {
                this["IsVisitorRecordLimited"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int VisitorCountLimit {
            get {
                return ((int)(this["VisitorCountLimit"]));
            }
            set {
                this["VisitorCountLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsAutoBuildEnabled {
            get {
                return ((bool)(this["IsAutoBuildEnabled"]));
            }
            set {
                this["IsAutoBuildEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsShowingAnchors {
            get {
                return ((bool)(this["IsShowingAnchors"]));
            }
            set {
                this["IsShowingAnchors"] = value;
            }
        }
    }
}
