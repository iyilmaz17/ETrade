using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public decimal UnitPrice { get; set; }
        public int TaxRate { get; set; }
        public DateTime AddedDate { get; set; }
        public byte Stock { get; set; }
        public string Brand { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public byte CategoryId { get; set; }
    }
}
