using System.Windows;
using System.Windows.Controls;
using Todo.ViewModels;

namespace Todo.Views
{
    /// <summary>
    /// Logique d'interaction pour MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private Page SettingsPage;
        private StickyNotesViewModel ViewModel = new StickyNotesViewModel();

        public MainPage()
        {
            InitializeComponent();
            SettingsPage = new SettingsPage(this);
        }

        private void btnAddStickyNote_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(SettingsPage);
        }

        private void btnCloseApp_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }


    }
}
