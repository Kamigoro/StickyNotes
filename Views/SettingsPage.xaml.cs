using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StickyGO.Views
{
    /// <summary>
    /// Logique d'interaction pour SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {

        private Page MainPage;

        private Point offset;
        private IInputElement relativeTo;
        private bool mouseDown;

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

        /*private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.GetPosition(relativeTo).X;
            offset.Y = e.GetPosition(relativeTo).Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPosition = PointToScreen(offset);
                this.
            }
        }*/
    }
}
