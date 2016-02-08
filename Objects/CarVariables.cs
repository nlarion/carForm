using System;
using System.Collections.Generic;
using Nancy.Owin;
using Nancy;
using Nancy.ViewEngines.Razor;

namespace Cars.project1
{
  public class Car : NancyModule
  {
    private string _makeModel;
    private string _picture;
    private int _price;
    private int _miles;

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (_price < maxPrice && _miles < maxMiles);
    }

    public void SetMake(string makeModel)
    {
      _makeModel = makeModel;
    }

    public string GetMake()
    {
      return _makeModel;
    }

    public void SetPrice(int price)
    {
      _price = price;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetMiles(int miles)
    {
      _miles = miles;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetPicture(string picture)
    {
      _picture = picture;
    }

    public string GetPicture()
    {
      return _picture;
    }

  }

  public class Program
  {
    public static void Main()
    {
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

    }
  }
}
