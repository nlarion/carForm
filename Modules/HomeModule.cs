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
        List<string> allCarsString = Car.GetAllString();
        List<string> returnCarsString = new List<string>{};
        List<Car> allCars = Car.GetAll();
        foreach (Car automobile in allCars)
        {
          if (automobile.WorthBuying(maxPrice, maxMiles))
          {
            string carname = automobile.GetMake();
            returnCarsString.Add(carname);
          }
        }
        return View["car.cshtml", returnCarsString];
      };
    }
  }
}
