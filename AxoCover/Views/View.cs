﻿using AxoCover.Controls;
using AxoCover.Models;
using AxoCover.ViewModels;
using Unity;
using System.Windows;
using System.Windows.Controls;

namespace AxoCover.Views
{
  public abstract class View<T> : UserControl
    where T : ViewModel
  {
    public T ViewModel { get; private set; }

    public View()
    {
      SharedDictionaryManager.InitializeDictionaries(Resources.MergedDictionaries);
      ViewModel = ContainerProvider.Container?.Resolve<T>();
      Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
      (Content as FrameworkElement).DataContext = ViewModel;
    }
  }
}
