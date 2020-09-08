using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using StickyGO.Models;
using StickyGO.ViewModels;

namespace StickyGO.Views
{
    /// <summary>
    /// Logique d'interaction pour MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private Page SettingsPage;
        private MainPageViewModel MainPageViewModel = new MainPageViewModel();

        public MainPage()
        {
            SettingsPage = new SettingsPage(this);
            DataContext = MainPageViewModel;
            InitializeComponent();
        }

        private void btnAddStickyNote_Click(object sender, RoutedEventArgs e)
        {
            MainPageViewModel.CreateNewStickyNote();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(SettingsPage);
        }

        private void btnCloseApp_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnSearchStickyNote_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
