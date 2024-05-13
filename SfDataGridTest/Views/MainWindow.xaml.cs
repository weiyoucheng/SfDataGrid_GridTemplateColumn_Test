using Microsoft.UI.Xaml;
using SfDataGridTest.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SfDataGridTest.Views {
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window {
        public MainWindowViewModel ViewModel { get; set; }

        public MainWindow() {
            ViewModel = new MainWindowViewModel();
            this.InitializeComponent();
        }

    }
}
