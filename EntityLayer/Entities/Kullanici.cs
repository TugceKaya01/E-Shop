using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "İsim")]
        [StringLength(30, ErrorMessage = "En Fazla 30 Karakter Kullanılabilir!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Soyisim")]
        [StringLength(30, ErrorMessage = "En Fazla 30 Karakter Kullanılabilir!")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "E-mail")]
        [StringLength(30, ErrorMessage = "En Fazla 30 Karakter Kullanılabilir!")]
        [EmailAddress(ErrorMessage = "E-mail Formatına Uygun Yazmanız Gerekmektedir!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(30, ErrorMessage = "En Fazla 30 Karakter Kullanılabilir!")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Şifre")]
        [StringLength(10, ErrorMessage = "En Fazla 10 Karakter Kullanılabilir!")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }


        [Required(ErrorMessage = "Bu Bölüm Boş Geçilemez!")]
        [Display(Name = "Şifre")]
        [StringLength(10, ErrorMessage = "En Fazla 10 Karakter Kullanılabilir!")]
        [DataType(DataType.Password)]
        [Compare("Sifre", ErrorMessage = "Hatalı Şifre Girdiniz...")]

        public string SifreTekrari { get; set; }

        [StringLength(10, ErrorMessage = "En Fazla 10 Karakter Kullanılabilir!")]
        public string Rol { get; set; }
    }
}
