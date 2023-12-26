using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
   public class Kategori
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "İsim")]
        [StringLength(30, ErrorMessage = "En Fazla 30 Karakter Kullanılabilir!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Açıklama")]
        [StringLength(90, ErrorMessage = "En Fazla 90 Karakter Kullanılabilir!")]
        public string Aciklama { get; set; }

        public virtual List <Urun> Urunler { get; set; }
    }
}
