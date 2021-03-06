﻿using MVVMLibrary;
using System.Windows;
using WatchOnlyGroestlcoinWallet.ViewModels;
using WatchOnlyGroestlcoinWallet.Views;

namespace WatchOnlyGroestlcoinWallet.Services
{
    public interface IWindowManager
    {
        void Show(CommonBase ViewModel);
    }

    public class SettingsWindowManager : IWindowManager
    {
        public void Show(CommonBase ViewModel)
        {
            SettingsWindow myWin = new SettingsWindow();
            myWin.DataContext = ViewModel;
            myWin.Owner = Application.Current.MainWindow;
            myWin.ShowDialog();
        }
    }

    public class ImportWindowManager : IWindowManager
    {
        public void Show(CommonBase ViewModel)
        {
            ImportWindow myWin = new ImportWindow();
            myWin.DataContext = ViewModel;
            ((ImportViewModel)ViewModel).ClosingRequest += (sender, e) => myWin.Close();
            myWin.Owner = Application.Current.MainWindow;
            myWin.ShowDialog();
        }
    }
}