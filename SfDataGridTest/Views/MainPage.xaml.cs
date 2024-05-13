using Microsoft.UI.Xaml.Controls;
using SfDataGridTest.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SfDataGridTest.Views {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        public MainPageViewModel ViewModel { get; set; }
        public MainPage() {
            ViewModel = new MainPageViewModel();
            this.InitializeComponent();
     
        }
    }
}
