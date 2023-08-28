﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int SubCategory1 { get; set; }
        public int SubCategory2 { get; set; }
        //public string CategoryName1 { get; set; }
        //public string CategoryName2 { get; set; }
        //public string CategoryName3 { get; set; }
        //public string? CategoryName4 { get; set; }

    }
}
