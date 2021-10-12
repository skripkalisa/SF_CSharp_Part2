using System;

namespace Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherForecast(1);
            WeatherForecast(2);
            WeatherForecast(3);
        }

        private static void WeatherForecast(int scale)
        {
            string period = "daily";
            int upperMargin = 30;
            switch(scale)
            {
                case 1:
                    break;
                case 2:
                    period = "weekly";
                    upperMargin = 35;
                    break;                
                case 3:
                    period = "monthly";
                    upperMargin = 35;
                    break;
            }
            
            Console.WriteLine($"Welcome to the {period} forecast page");
            Console.WriteLine( $"The average temperature is expected to be around " +
                               $"{new Random().Next(10, upperMargin)} C");
            
        }
    }
}