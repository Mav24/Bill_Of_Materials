using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValcomData
{
    public class SupplierLineItems
    {
        public int Id { get; set; }
        public string Supplier { get; set; }
        public string PartID { get; set; }
        public string PartDescription { get; set; }
        public string ManufacturerName { get; set; }
    }
}
