using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public  class CartSummary : IEntity
    {
        
        public string ProductName { get; set; }
        public string CartCode { get; set; }
        public byte  Amount { get; set; }
        public bool Status { get; set; }
    }
}
