using System.ComponentModel;
using System.Web.Mvc;
using BT_Widgets.Mvc.Models.BT_ModuleTest_CtEmployee;
using Telerik.Sitefinity.Mvc;

namespace BT_Widgets.Mvc.Controllers
{
    //[EnhanceViewEngines]
    [ControllerToolboxItem(Name = "BT_ModuleTest_CtEmployee", Title = "BT_ModuleTest_CtEmployee", SectionName = "Test_BT")]
    public class BT_ModuleTest_CtEmployeeController : Controller
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public BT_ModuleTest_CtEmployeeModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = new BT_ModuleTest_CtEmployeeModel();

                return this.model;
            }
        }

        public string Template
        {
            get { return this.template; }
            set { this.template = value; }
        }

        public ActionResult Index()
        {
            var m_object = this.Model.GetViewModel();
            m_object.EmpName_VM = "Employee Name not needed in list case";
            m_object.List_CtEmployee = this.Model.RetrieveCtEmployee();

            foreach (var m_var in m_object.List_CtEmployee)
            {
                //Telerik.Sitefinity.DynamicTypes.Model..Ct_employee bb = new Telerik.Sitefinity.DynamicTypes.Model.Module_Test.Ct_employee();
                //string name =((Telerik.Sitefinity.DynamicTypes.Model.Module_Test.Ct_employee)m_var).Address;
            }
            

            return this.View("BT_ModuleTest_CtEmployee." + this.Template, m_object);
        }
        private BT_ModuleTest_CtEmployeeModel model;
        private string template = "Default";
    }
}



