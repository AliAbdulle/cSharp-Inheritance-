using System;

namespace cSharp_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "Midnight Blue";

            Tesla modelS = new Tesla();
            modelS.MainColor = "Burgundy";

            Cessna mx410 = new Cessna();
            mx410.MainColor = "White ";

            Ram vol = new Ram();
            vol.MainColor = "Silver ";

            fxs.Drive();
            //modelS.Drive();
             mx410.Drive();
        }
    }
}
