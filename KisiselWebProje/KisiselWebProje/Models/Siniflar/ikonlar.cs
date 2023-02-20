using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace KisiselWebProje.Models.Siniflar
{
    public class ikonlar
    {
        [Key]
        public int ID { get; set; }
        public string ikon { get; set; }
        public string link { get; set; }
    }
}