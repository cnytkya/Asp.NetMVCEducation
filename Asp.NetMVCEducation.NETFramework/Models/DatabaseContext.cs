using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp.NetMVCEducation.NETFramework.Models
{
    public class DatabaseContext : DbContext // DatabaseContext bizim db setlerimizi tutacak classımız. DbContext ise Entity frameworkün veritabanı işlemleri için bize sunduğu class
    {
        public DbSet<Product> Products { get; set; } // Veritabanı tablolarımızı temsil edecek classlarımızı dbset olarak tanımlıyoruz
        public DbSet<Category> Categories { get; set; }
        
    }
}