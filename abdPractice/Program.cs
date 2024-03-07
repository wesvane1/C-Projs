using System;

namespace AbstractionPractice
{
  class Program
  {
    static void Main(string[] args)
    {
      // abstract classes - modifier that indicated missing components or incomplete implementation

      Car car = new Car();
      Bike bike = new Bike();
      Boat boat = new Boat();
      
      // Err creating instance, because it is incomplete, the user needs to create a TYPE of vehicle. Not just a generic vehicle.
      // Vehicle vehicle = new Vehicle();
    }
  }

  abstract class Vehicle
  {
    public int speed = 0;

    public void go()
    {
      Console.WriteLine("The vehicle is moving!");
    }
  }

  class Car : Vehicle
  {
    public int wheels = 4;
    int maxSpeed = 500;
  }

  class Bike : Vehicle
  {
    public int wheels = 2;
    int maxSpeed = 15;
  }

  class Boat : Vehicle
  {
    public int wheels = 0;
    int maxSpeed = 100;
  }
}