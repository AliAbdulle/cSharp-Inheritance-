
using System;

namespace cSharp_Inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn()
        {
            Console.WriteLine("The Vehicle carefully turn right!");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently roll to a stop!");
        }
    }
}