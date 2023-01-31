using Xiang.Models;

namespace Xiang.ViewModel
{
    public class AOrderViewModel
    {
        private Aorder _aorder;
        //private Advertise _advertise;
        //private Supplier _supplier;
        public Aorder aorder
        {
            get { return _aorder; }
            set { _aorder = value; }
        }
        //public Advertise advertise
        //{
        //    get { return _advertise; }
        //    set { _advertise = value; }
        //}
        //public Supplier supplier
        //{
        //    get { return _supplier; }
        //    set { _supplier = value; }
        //}

        public AOrderViewModel() { _aorder = new Aorder(); /*_advertise = new Advertise(); _supplier = new Supplier();*/ }
        public int? AorderId { get { return _aorder.AorderId; } set { _aorder.AorderId = value; } }
        public int? SupplierId { get { return _aorder.SupplierId; } set { _aorder.SupplierId = value; } }
        //public string? SupplierName { get { return _supplier.Name; } set { _supplier.Name = value; } }
        public int? AdvertiseId { get { return _aorder.AdvertiseId; } set { _aorder.AdvertiseId = value; } }
        //public string? AdvertiseName { get { return _advertise.Name; } set { _advertise.Name = value; } }
        public DateTime? OrderDate { get { return _aorder.OrderDate; } set { _aorder.OrderDate = value; } }
        public DateTime? EndDate { get { return _aorder.EndDate; } set { _aorder.EndDate = value; } }
        public int? Clicks { get { return _aorder.Clicks; } set { _aorder.Clicks = value; } }

        public virtual Advertise? Advertise { get { return _aorder.Advertise; } set { _aorder.Advertise = value; } }
        public virtual Supplier? Supplier { get { return _aorder.Supplier; } set { _aorder.Supplier = value; } }
    }
}
