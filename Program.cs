using System;

namespace cSharp_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "Midnight Blue";

            ZeroCart fxs1 = new ZeroCart();
            fxs1.MainColor = "black";

            Tesla modelS = new Tesla();
            modelS.MainColor = "Burgundy";

            Cessna mx410 = new Cessna();
            mx410.MainColor = "White ";

            Ram vol = new Ram();
            vol.MainColor = "Silver ";

            fxs.Drive();
            fxs1.Drive();
            modelS.Drive();
            mx410.Drive();
            vol.Drive();
        }
    }
}
