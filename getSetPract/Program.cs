using System;

class Program
{
  static void Main(string[] args)
  {
    // Car car = new Car("RedBull", 321, "kph");
    // Car car1 = new Car("Williams", 323, "kph");
    // Car car2 = new Car("Alpine", 150, "kph");

    // car.Speed = 1000000;
    List<Car> cars = new List<Car>
    {
      new Car("RedBull", 321, "kph"),
      new Car("Williams", 323, "kph"),
      new Car("Alpine", 150, "kph")
    };
    foreach(Car car in cars)
    {
      Console.WriteLine($"The {car.Type} is going {car.Speed}{car.Unit}");
    }

  }

  class Car
  {
    private string type;
    private int speed;
    private string unit;

    public Car(string type, int speed, string unit)
    {
      Type = type;
      Speed = speed;
      Unit = unit;
    }

    public string Unit
    {
      get {return unit;}
      set {unit = value; }
    }

    public string Type
    {
      get {return type; }
      set {type = value; }
    }

    public int Speed
    {
      get { return speed; } //This reads the value that was put above in the new Car method
      set
      {
        if( value > 500)
        {
          speed = 500;
        }
        else
        {
          speed = value;
        }
        //value is like the parameter
      }
    }
  }
}