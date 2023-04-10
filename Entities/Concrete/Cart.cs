﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cart:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CartCode { get; set;}
        public int ProductId { get; set; }
        public byte Amount { get; set; }
        public bool Status { get; set; }
    }
}
