using System;
namespace cSharp_Inheritance{
    public class Ram :Vehicle
    {  // Electric motorcycle
    public double BatteryKWh { get; set; }

    public void RefuelTank () {  }
     public override void Drive()
    {
        Console.WriteLine($"The {MainColor}Ram growls by you like herricane. Rrrrrruuuuummmbbbble!");
    }
    public override void Turn()
    {
        Console.WriteLine($"The vehicle cerfully turn right");
    }
    public override void Stop()
    {
        Console.WriteLine($"The vehicle gently rolls to a stop!");
        Console.WriteLine("  ");
    }
}
}