using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Satislar
    {
        public int Id { get; set; }

        [Display(Name = "Ürün")]
        public int UrunId { get; set; }

        [Display(Name = "Adet")]
        public int Adet { get; set; }

        [Display(Name = "Fiyat")]
        public decimal Fiyat { get; set; }

        [Display(Name = "Tarih")]
        public DateTime Tarih { get; set; }

        [Display(Name = "Resim")]
        public string Resim { get; set; }

        [Display(Name = "Kullanıcı")]
        public int KullaniciId { get; set; }

    }
}
