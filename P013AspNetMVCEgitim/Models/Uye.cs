using System.ComponentModel.DataAnnotations;

namespace P013AspNetMVCEgitim.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad Alanı Boş Geçilemez!"), StringLength(50)] // StringLength ile ad alanına ka. karakter gönderilebilceğini sınırlayabiliriz
        public string Ad { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez!"), StringLength(50)] //{0} yazdığımızda değişken adı ne ise onu otomatik alır. Bu örnekte Soyad ı otomatik olarak çeker
        public string Soyad { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez!"), StringLength(50)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez!"), StringLength(50)]
        public string? Telefon { get; set; } //Normalde telefon alanı zorunlu, ama değer tipinin yanına ? eklersek zorunlu olmaktan çıkar. Boş bırakılsa da üye kaydı tamamlanabilir.
        [Display(Name = "TC Kimlik Numarası")] //Ekranda TcKimlikNo yerine TC Kimlik Numarası yazar.
        [MinLength(11, ErrorMessage = "{0} 11 Karakter Olmalıdır!")]
        [MaxLength(11, ErrorMessage = "{0} 11 Karakter Olmalıdır!")]
        public string? TcKimlikNo { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime? DogumTarihi { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }
        [Display(Name = "Şifre Tekrar")]
        public string SifreTekrar { get; set; }
    }
}
