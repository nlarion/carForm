using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car
  {
    private string _makeModel;
    private string _picture;
    private int _price;
    private int _miles;
    private static List<Car> _carList = new List<Car> {};

    public Car(string make, int price, int miles, string picture)
    {
        _makeModel = make;
        _price = price;
        _miles = miles;
        _picture = picture;
    }
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
    public static List<Car> GetAll()
    {
      return _carList;
    }
    public static void Save(Car car)
    {
      _carList.Add(car);
    }
  }

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2014 Porsche 911",114991,7864,"/Content/img/911.jpg");
      Car.Save(porsche);

      Car ford = new Car("2011 Ford F450",55995,14241,"/Content/img/f450.jpg");
      Car.Save(ford);

      Car lexus = new Car("2013 Lexus RX 350",44700,20000,"/Content/img/lexus.jpg");
      Car.Save(lexus);

      Car mercedes = new Car("Mercedes Benz CLS550",39900,37979,"/Content/img/benz.JPG");
      Car.Save(mercedes);
    }
  }
}
