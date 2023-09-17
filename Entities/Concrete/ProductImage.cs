﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class ProductImage : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public DateTime UploadDate { get; set; }
        public bool HomeImage { get; set; }
    }
}
