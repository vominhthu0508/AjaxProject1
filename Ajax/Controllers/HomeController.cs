using Ajax.Data;
using Ajax.Data.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Ajax.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeDbContext _context;
        public HomeController()
        {
            _context = new EmployeeDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public JsonResult LoadData()
        //{
            
        //    return Json(new
        //    {
        //        data=listEmployee,
        //        status=true
        //    },JsonRequestBehavior.AllowGet);
        //}

        [HttpGet]
        public JsonResult LoadData(int page, int pageSize)
        {

            var model = _context.Employees
                .OrderBy(x=>x.ID)
                .Skip((page - 1) * pageSize).Take(pageSize);
            int totalRow = _context.Employees.Count();
            return Json(new
            {
                data = model,
                total=totalRow,
                status = true
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Update(string model)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Employee employee = serializer.Deserialize<Employee>(model);
            var entity=_context.Employees.Find(employee.ID);
            entity.Salary = employee.Salary;
            return Json(new
            {
                status = true
            });
        }
    }
}