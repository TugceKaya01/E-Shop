using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Urun
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "İsim")]
        [StringLength(30, ErrorMessage = "En Fazla 30 Karakter Kullanılabilir!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Açıklama")]
        [StringLength(50, ErrorMessage = "En Fazla 50 Karakter Kullanılabilir!")] 
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Fiyat")]
        public decimal Fiyat { get; set; }
        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Stok")]
        public int Stok { get; set; }
        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Popüler")]
        public bool Popular { get; set; }
        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Onay")]
        public bool OnaylıMı { get; set; }
        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Resim")]
        public string Image { get; set; }
      
        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Kategori")]
        public int KategoriId { get; set; }

        public virtual Kategori Kategori { get; set; }
    }
}
