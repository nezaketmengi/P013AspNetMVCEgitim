using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Models;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC04ModelBindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KullaniciDetay()
        {
            Kullanici kullanici = new();
            kullanici.KullaniciAdi = "Admin";
            kullanici.Ad = "Nezaket";
            kullanici.Soyad = "Mengi";
            kullanici.Sifre = "123";
            kullanici.Email = "nezaketmengi.com";
            return View(kullanici); // View içerisinde model datası olarak kullanıcı nesnesini sayfaya yönlendirdik.
        }
        [HttpPost]
        public IActionResult KullaniciDetay(Kullanici kullanici) // post metodunda modelden gelen nesneyi bu şekilde parantez içinde yakalayabiliyoruz.
        {
            return View(kullanici); // gelen kullanici nesnesini tekrardan ekrana yolla
        }
        public IActionResult AdresDetay()
        {
            Adres adres = new()
            {
                Sehir = "İstanbul", Ilce = "Maltepe", AcikAdres = "Cemalbey Caddesi"
            };
            return View(adres);
        }
        public IActionResult UyeSayfasi()
        {
            Kullanici kullanici = new();
            kullanici.KullaniciAdi = "Admin";
            kullanici.Ad = "Nezaket";
            kullanici.Soyad = "Mengi";
            kullanici.Sifre = "123";
            kullanici.Email = "nezaketmengi.com";

            Adres adres = new()
            {
                Sehir = "İstanbul",
                Ilce = "Maltepe",
                AcikAdres = "Cemalbey Caddesi"
            };

            var model = new UyeSayfasiViewModel()
            {
                kullanici = kullanici,
                Adres = adres
            };
            return View();
        }
    }
}
