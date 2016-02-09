using Nancy;
using System.Collections.Generic;
using Cars.Objects;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        Program.Main();
        return View["form.cshtml"];
      };
      Post["/car"] = _ => {
        int maxPrice = int.Parse(Request.Form["maxPrice"]);
        int maxMiles = int.Parse(Request.Form["maxMiles"]);
        List<Car> returnCars = new List<Car>{};
        List<Car> allCars = Car.GetAll();
        foreach (Car automobile in allCars)
        {
          if (automobile.WorthBuying(maxPrice, maxMiles))
          {
            returnCars.Add(automobile);
          }
        }
        return View["car.cshtml", returnCars];
      };
    }
  }
}
