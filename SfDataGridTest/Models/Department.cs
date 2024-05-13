using CommunityToolkit.Mvvm.ComponentModel;

namespace SfDataGridTest.Models {
    public partial class Department :ObservableValidator {
        [ObservableProperty]
        private int _id;

        [ObservableProperty]
        private string _name;

        public Department(int id, string name) {
            _id = id;
            _name = name;
        }
    }
}
