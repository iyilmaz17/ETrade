using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CustomerProductDto
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public decimal UnitPrice { get; set; }
        public int TaxRate { get; set; }
        public byte Stock { get; set; }
        public string Brand { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public byte CategoryId1 { get; set; }
        public byte CategoryId2 { get; set; }
        public byte? CategoryId3 { get; set; }
        public DateTime AddedDate { get; set; }
        public string ImagePath { get; set; }
    }
}
