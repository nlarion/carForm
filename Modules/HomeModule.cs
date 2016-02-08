using Nancy.Owin;
using Nancy;
using Nancy.ViewEngines.Razor;
using System.Collections.Generic;
using System.IO;
using System;
using Microsoft.AspNet.Builder;
using Cars.project1;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["form.cshtml"];
      };
      Post["/car"] = _ => {
        Car porsche = new Car();
        porsche.SetMake("2014 Porsche 911");
        porsche.SetPrice(114991);
        porsche.SetMiles(7864);
        porsche.SetPicture("/Content/img/911.jpg");

        Car ford = new Car();
        ford.SetMake("2011 Ford F450");
        ford.SetPrice(55995);
        ford.SetMiles(14241);
        ford.SetPicture("/Content/img/f450.jpg");

        Car lexus = new Car();
        lexus.SetMake("2013 Lexus RX 350");
        lexus.SetPrice(44700);
        lexus.SetMiles(20000);
        lexus.SetPicture("/Content/img/lexus.jpg");

        Car mercedes = new Car();
        mercedes.SetMake("Mercedes Benz CLS550");
        mercedes.SetPrice(39900);
        mercedes.SetMiles(37979);
        mercedes.SetPicture("/Content/img/benz.JPG");
        List<Car> CarList = new List<Car>() { porsche, ford, lexus, mercedes };

        int maxPrice = int.Parse(Request.Form["maxPrice"]);
        int maxMiles = int.Parse(Request.Form["maxMiles"]);

        List<Car> CarsMatchingSearch = new List<Car>();
        foreach (Car automobile in CarList)
        {
          if (automobile.WorthBuying(maxPrice, maxMiles))
          {
            CarsMatchingSearch.Add(automobile);
          }
        }

        return View["car.cshtml", CarsMatchingSearch];
      };
    }
  }
}
