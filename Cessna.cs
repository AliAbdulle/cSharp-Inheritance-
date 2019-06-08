using System;
namespace cSharp_Inheritance
{
    public class Cessna : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void RefuelTank() { }

        public override void Drive()
    {
        Console.WriteLine($"The {MainColor}Cessna flashes by you like herricane. Zzzzzoooooommmm!");
    }
     public override void Turn()
    {
        Console.WriteLine($"The vehicle cerfully turn right");
    }
        public override void Stop()
    {
        Console.WriteLine($"The {MainColor}Cessna roll down the runway for a mile and stop.");
        Console.WriteLine("  ");
    }
    }
}