using System;

namespace PolyPractice
{
  class Program
  {
    static void Main(string[] args)
    {
      Car car = new Car();
      Bike bike = new Bike();
      Boat boat = new Boat();

      Vehicle[] vehicles = { car, bike, boat };

      foreach(Vehicle vehicle in vehicles)
      {
        vehicle.Go();
      }

      Console.ReadKey();
    }
  }

  abstract class Vehicle
  {
    public virtual void Go()
    {
      // This method can be left blank, because all other classes will be overriding it with their respective Go methods
    }
  }

  class Car : Vehicle
  {
    public override void Go()
    {
      Console.WriteLine("The car is moving!");
    }
  }

  class Bike : Vehicle
  {
    public override void Go()
    {
      Console.WriteLine("The bike is moving!");
    }
  }

  class Boat : Vehicle
  {
    public override void Go()
    {
      Console.WriteLine("The boat is moving!");
    }
  }
}