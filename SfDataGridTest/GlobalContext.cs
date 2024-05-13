using SfDataGridTest.Models;

namespace SfDataGridTest {
    public  class GlobalContext {
        public static GlobalResource Data { get; set; } = new GlobalResource();
    }


    public class GlobalResource {
        public Department[] Departments { get; set; }
    }

}
