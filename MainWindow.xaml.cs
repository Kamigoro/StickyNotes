using System.Windows;
using System.Windows.Controls;
using Todo.Views;

namespace Todo
{
    public partial class MainWindow : Window
    {

        private Page MainPage = new MainPage();

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(MainPage);
        }
    }
}
