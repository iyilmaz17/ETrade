﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SubcategoryOne : IEntity
    {
        public int Id { get; set; }
        public int ParentCategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
