using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace AjaxCore.Models
{
    public class Kullanici
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string ResimAd { get; set; }

        [NotMapped] 
        public IFormFile File { get; set; }
    }
}
