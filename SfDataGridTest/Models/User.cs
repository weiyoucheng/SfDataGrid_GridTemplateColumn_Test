using CommunityToolkit.Mvvm.ComponentModel;

namespace SfDataGridTest.Models {
    public  partial class User :ObservableValidator {

        [ObservableProperty]
        private int _id;

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _phone;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private Department _department;

        public User(int id, string name, string phone, string email, Department department) {
            _id = id;
            _name = name;
            _phone = phone;
            _email = email;
            _department = department;
        }
    }
}
