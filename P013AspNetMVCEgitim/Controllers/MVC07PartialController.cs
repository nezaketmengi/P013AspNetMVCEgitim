﻿using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Models;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC07PartialController : Controller
    {
        public IActionResult Index()
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Ad = "Nezaket";
            kullanici.Soyad = "Mengi";
            return View(kullanici);
        }
    }
}
