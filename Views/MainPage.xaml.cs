using StickyGO.Views;
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
            SettingsPage = new SettingsPage(this);
            DataContext = ViewModel;
            InitializeComponent();
        }

        private void btnAddStickyNote_Click(object sender, RoutedEventArgs e)
        {
            StickyNoteView view = new StickyNoteView();
            view.Show();
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
