using System.Windows;
using System.Windows.Controls;

namespace Todo.Views
{
    /// <summary>
    /// Logique d'interaction pour SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {

        private Page MainPage;

        public SettingsPage(Page mainPage)
        {
            InitializeComponent();
            MainPage = mainPage;
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(MainPage);
        }

        private void btnCloseApp_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }


    }
}
