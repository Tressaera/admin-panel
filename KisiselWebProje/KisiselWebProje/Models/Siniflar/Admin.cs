using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace KisiselWebProje.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string kullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}