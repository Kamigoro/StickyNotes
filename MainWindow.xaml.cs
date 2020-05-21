using System.Windows;
using System.Windows.Controls;
using StickyGO.Views;

namespace StickyGO
{
    public partial class MainWindow : Window
    {

        private Page MainPage = new MainPage();

        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(MainPage);
        }
    }
}
