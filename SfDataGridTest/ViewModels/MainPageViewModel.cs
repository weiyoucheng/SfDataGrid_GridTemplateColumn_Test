using CommunityToolkit.Mvvm.ComponentModel;
using SfDataGridTest.Models;
using System.Collections.Generic;

namespace SfDataGridTest.ViewModels {
    public partial class MainPageViewModel :ObservableObject{

        [ObservableProperty]
        private IEnumerable<User> _users;

        [ObservableProperty]
        private User? _user;

        [ObservableProperty]
        private Department? _department;

        [ObservableProperty]
        private IList<Department> _departments;

        public MainPageViewModel() {
            GlobalContext.Data.Departments = new Department[] {
                new Department(1,"CustomerService"),
                new Department(2,"Finance"),
                new Department(3,"Personnel"),
                new Department(4,"Business"),
                new Department(5,"Sales")
            };
            _departments = GlobalContext.Data.Departments;

            _users = new User[]{
                new User(1,"Alice","123456","123456@outlook.com",Departments[0]),
                new User(2,"Adam","123456","123456@outlook.com", Departments[4]),
                new User(3,"Mike","123456","123456@outlook.com", Departments[3]),
                new User(4,"Jenny","123456","123456@outlook.com",Departments[1]),
                new User(5,"Luci","123456","123456@outlook.com", Departments[2])
            };
        }
    }
}
