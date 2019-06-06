using System;
namespace cSharp_Inheritance{
    public class Tesla : Vehicle
     {  // Electric motorcycle
    public double BatteryKWh { get; set; }

    public void ChargeBattery () {  }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla Blazes by you. MMmmmmmmmmmm!");
    }
}
}