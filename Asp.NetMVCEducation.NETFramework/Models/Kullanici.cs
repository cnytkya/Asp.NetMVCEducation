﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.NetMVCEducation.NETFramework.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}