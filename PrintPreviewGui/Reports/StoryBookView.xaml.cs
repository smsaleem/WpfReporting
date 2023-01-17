using System.Windows.Controls;

using Sherman.WpfReporting.Gui.ViewModels;

namespace Sherman.WpfReporting.Gui.Reports
{
    /// <summary>
    /// Interaction logic for StoryBookView.xaml
    /// </summary>
    public partial class StoryBookView : UserControl
    {
        public StoryBookView(StoryBookViewModel vm )
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
