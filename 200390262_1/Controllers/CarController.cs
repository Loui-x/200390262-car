using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _200390262_1.Models;
namespace _200390262_1.Controllers
{
    public class CarController : Controller
    {
        public ActionResult Index()
        {
            return View(carlist);
        }


        List<Car> carlist = new List<Car>()
        {
            new Car {id=1, Brand ="Toyota",Model ="corolA", Type="compact", Year=2019},
            new Car {id=2, Brand ="Toyota",Model ="Land cruiser", Type="compact", Year=2009},
            new Car {id=3, Brand ="Toyota",Model ="Prado", Type="compact", Year=1919}
        };
       public ActionResult Detail(int id)
        {
            //String n = String.Format("{0}", Request.Form["input_id"]);
            //int ID_input = Convert.ToInt32(n);
                if (id==null || id > carlist.Count)
            {
                return Content("Invalid car id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carlist[ind];
            return View(car);
        }
    }
}