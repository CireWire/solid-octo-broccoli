using System;

class MainClass 
{
  class Car
  {
    public string name;
    public int year;
  }

  public static void Main (string[] args) 
  {
    Car c1 = new Car();
    c1.name = "Nuka";
    c1.year = 2172;
    Console.WriteLine ("{0} is such an awesome car!", c1.name);
  }
}
