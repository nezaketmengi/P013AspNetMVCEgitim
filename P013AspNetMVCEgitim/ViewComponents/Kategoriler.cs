﻿using Microsoft.AspNetCore.Mvc;

namespace P013AspNetMVCEgitim.ViewComponents
{
    public class Kategoriler : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // db ye bağlanıp kategorileri çekip compenente getirebiliriz.
            return View();
        }
    }
}
