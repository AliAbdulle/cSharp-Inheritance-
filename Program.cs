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
            fxs.Turn();
            fxs.Stop();

            fxs1.Drive();
            fxs1.Turn();
            fxs1.Stop();

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();

            vol.Drive();
            vol.Turn();
            vol.Stop();
        }
    }
}
