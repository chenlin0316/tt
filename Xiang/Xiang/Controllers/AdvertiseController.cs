using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Xiang.Models;
using Xiang.ViewModel;

namespace Xiang.Controllers
{
    public class AdvertiseController : Controller
    {
        public IActionResult List()
        {
            IEnumerable<AOrderViewModel> aorders = null;
            IEnumerable<Supplier> supplier = null;
            //IEnumerable<Advertise> advertises = null;
            dbXContext db = new dbXContext();
            supplier = from t in db.Suppliers select t;
            //advertises = from t in db.Advertises select t;

            aorders = from t in db.Aorders select new AOrderViewModel 
            {
                AorderId = t.AorderId,
                SupplierId= t.SupplierId,
                AdvertiseId= t.AdvertiseId,
                OrderDate= t.OrderDate,
                EndDate= t.EndDate,
                Clicks= t.Clicks,
                Supplier = (Supplier)supplier,
                //Advertise = (Advertise)advertises
            };            

            return View(aorders);
        }
    }
}
