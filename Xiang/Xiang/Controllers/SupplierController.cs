using Microsoft.AspNetCore.Mvc;
using Xiang.Models;
using Xiang.ViewModel;

namespace Xiang.Controllers
{
    public class SupplierController : Controller
    {

        public IActionResult List()
        {
            IEnumerable<SupplierViewModel> datas = null;
            dbXContext db=new dbXContext();
            datas = from t in db.Suppliers
                    select new SupplierViewModel {
                       Address= t.Address,
                       Email = t.Email,
                       Phone= t.Phone,
                    };
            
          //  SupplierViewModel
            return View(datas);
        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Supplier p)
        {
            dbXContext db = new dbXContext();
            db.Suppliers.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }


        public IActionResult Index()
        {
            return View();
        }

    }
}
