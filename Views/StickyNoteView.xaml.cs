using System.Windows;

namespace StickyGO.Views
{
    /// <summary>
    /// Logique d'interaction pour StickyNoteView.xaml
    /// </summary>
    public partial class StickyNoteView : Window
    {
        public StickyNoteView()
        {
            InitializeComponent();
        }

        private void btnAddStickyNote_Click(object sender, RoutedEventArgs e)
        {
            StickyNoteView view = new StickyNoteView();
            view.Show();
        }

        private void btnSaveStickyNote_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
