using AspNetMvcApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNetMvcApplication.ViewComponents
{
    public class PersonelWiewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Personel> datas = new List<Personel>
            {
                new Personel {Name="Kadir",LastName="Aztekin"},
                new Personel {Name="Hüseyin",LastName="Aztekin"},
                new Personel {Name="Nisa",LastName="Aztekin"},
                new Personel {Name="Şule",LastName="Aztekin"},
            };
            return View(datas);
        }
    }
}
