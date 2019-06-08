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
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Tesla squeals around a right turn.");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla silently stop as if it never moved.");
        Console.WriteLine("  ");
    }
}
}