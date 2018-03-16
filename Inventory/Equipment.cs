using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Panel
{
    class Equipment
    {
        public string Type {get; set; }
        public int ID { get; set; }
        public int Barcode {get; set; }
        public int SerialNumber { get; set; }
        public int ITSNumber { get; set; }
        public string Status { get; set; }
        public string Availability { get; set; }
    }
}
