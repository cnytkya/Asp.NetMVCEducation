﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.NetMVCEducation.NETFramework.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        
    }
}