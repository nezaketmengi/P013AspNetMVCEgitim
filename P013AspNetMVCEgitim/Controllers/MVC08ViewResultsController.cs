using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Models;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC08ViewResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Yonlendir(string arananDeger)
        {
            //return Redirect("/Home"); // bu action tetiklendiğinde uygulama anasayfaya gitsin.
            //return Redirect($"/Home?kelime={arananDeger}"); // burada ? işaretinden sonraki kısım querystring yöntemiyle adres çubuğu üzerinden veri yollamak için
            return Redirect("https://getbootstrap.com/");
        }
        public IActionResult ActionaYonlendir()
        {
            //return RedirectToAction("Index"); // metot çalıştığında aynı controllerdaki bir actiona yönlendirmemizi sağlar
            return RedirectToAction("Index", "Home"); //metot çalıştığında farklı bir controller daki actiona bu şekilde yönlendirebiliriz.
        }
        public RedirectToRouteResult RouteYonlendir() // IActionResult da yapsaydık olurdu.
        {
            return RedirectToRoute("Default", new { controller="Home", action="Index", id = 18}); // metot çalıştığında route sistemiyle yönlendirme yapmamızı sağlar
        }
        public PartialViewResult KategorileriGetirPartial() // IActionResult da yapsaydık olurdu.
        {
            return PartialView("_KategorilerPartial");
        }
        public IActionResult XmlContentResult()
        {
            var xml = @"
                <kullanicilar>
                    <Kullanici>
                        <Adi>
                            Nezaket
                        </Adi>
                        <Soyadi>
                            Mengi
                        </Soyadi>
                    </Kullanici>
                    <Kullanici>
                        <Adi>
                            Tolga
                        </Adi>
                        <Soyadi>
                            Sonat
                        </Soyadi>
                    </Kullanici>

                </kullanicilar>

            ";
            return Content(xml, "application/xml"); // geriye xml içeriğini döndürdük. "application/xml" tipini belirledikten sonra bildiğin xml yapısına geliyor.
        }

        public IActionResult JsonDondur()
        {
            var kullanici = new Kullanici()
            {
                Ad = "Nezaket", Soyad = "Mengi", KullaniciAdi = "Nez"
            };
            return Json(kullanici);
        }
    }
}
