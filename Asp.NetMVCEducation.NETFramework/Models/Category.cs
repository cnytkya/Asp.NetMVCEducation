﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.NetMVCEducation.NETFramework.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Kategori Adı"), Required, StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; } // 1 kategorinin 1 den çok Product ı olabilir
        public Category()
        {
            Products = new List<Product>();
        }

    }
}