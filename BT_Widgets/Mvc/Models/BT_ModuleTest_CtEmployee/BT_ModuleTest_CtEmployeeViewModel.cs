using System.Linq;
using Telerik.Sitefinity.DynamicModules.Model;

namespace BT_Widgets.Mvc.Models.BT_ModuleTest_CtEmployee
{
    public class BT_ModuleTest_CtEmployeeViewModel
    {
        public string EmpName_VM { get; set;  }

        public IQueryable<DynamicContent> List_CtEmployee { get; set; }
    }
}
