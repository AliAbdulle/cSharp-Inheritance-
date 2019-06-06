using System;
namespace cSharp_Inheritance{
    public class Zero : Vehicle
    {  // Electric motorcycle
    public double BatteryKWh { get; set; }

    public void RefuelTank () {  }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} zero zip by you. Yeeeooooooowww!");
    }
}
}