using System;
using OpenCloseGoodExample.Profiles;
 
namespace OpenCloseGoodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardComputer = new BoardComputer();
          
            // посадка на землю
            boardComputer.PerformLanding(new GroundLandingProfile());
 
            Console.WriteLine();
          
            // посадка на воду
            boardComputer.PerformLanding(new WaterLandingProfile());
        }
    }
}