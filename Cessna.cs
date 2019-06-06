using System;
namespace cSharp_Inheritance
{
    public class Cessna : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void RefuelTank() { }

        public override void Drive()
        {
            Console.WriteLine("Zooooom");
        }
    }
}