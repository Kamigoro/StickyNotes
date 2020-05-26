using StickyGO.Models;
using StickyGO.Models.DataAccess;
using StickyGO.ViewModels;
using System.Windows;

namespace StickyGO.Views
{
    /// <summary>
    /// Logique d'interaction pour StickyNoteView.xaml
    /// </summary>
    public partial class StickyNoteView : Window
    {
        public StickyNoteViewModel StickyNoteViewModel { get; set; }

        public StickyNoteView()
        {
            StickyNoteViewModel = new StickyNoteViewModel();
            DataContext = StickyNoteViewModel;
            InitializeComponent();
        }

        public StickyNoteView(StickyNote stickyNote)
        {
            StickyNoteViewModel = new StickyNoteViewModel(stickyNote);
            DataContext = StickyNoteViewModel;
            InitializeComponent();
        }

        private void btnAddStickyNote_Click(object sender, RoutedEventArgs e)
        {
            StickyNoteView view = new StickyNoteView();
            view.Show();
        }

        private void btnSaveStickyNote_Click(object sender, RoutedEventArgs e)
        {
            //TODO A tester
            DataAccessor.SaveStickyNote( new StickyNote() { Text = StickyNoteText.Text , Color = "#d32f2f" } );
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
