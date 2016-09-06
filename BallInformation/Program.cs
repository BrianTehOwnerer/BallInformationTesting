using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the color of the ball R/G/B");
            byte Red = Convert.ToByte(Console.ReadLine());
            byte Green = Convert.ToByte(Console.ReadLine());
            byte Blue = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Does your ball have an Alpha value?");
            string alphavalueyesno = Console.ReadLine();
            //Color color = new Color(0, 0, 0, 0);
            if (alphavalueyesno == "yes")
            {
                Console.WriteLine("Awesome, how many of the alphas does it have?");
                byte Alpha = Convert.ToByte(Console.ReadLine());
                Color color = new Color(Red, Green, Blue, Alpha);
            }
            else
            {
                Color color = new Color(Red, Green, Blue);
            }
            Console.WriteLine("Please enter the size of the ball.");
            int radius = Convert.ToInt32(Console.ReadLine());
            Ball ball = new Ball(radius, 0, false);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do? Options are limited to the following\nGet the colors of the ball\nChange the colors of the ball");
                Console.WriteLine("Get size of the ball/n Set a new size for the ball/nBounse the ball /nPop the ball");
                string whatdo = Console.ReadLine();
                whatdo = whatdo.ToLower();

                if (whatdo == "get colors")
                {
                    Console.WriteLine($"The ball has the following color values\n {color.GetBallColorRed()}")
                }
                else if (whatdo == "change colors")
                {
                    
                }
                else if (whatdo == "get size")
                {
                    Console.WriteLine($"The ball has a radius of {ball.GetBallRadius()} units ");

                }
                else if (whatdo == "set size")
                {

                }
                else if (whatdo == "bounce")
                {
                    Console.WriteLine("How many times would you like to bounce the ball?");
                    int n = Convert.ToInt32(Console.ReadLine());
                    ball.BounceBall(n);
                }
                else if (whatdo == "pop")
                {
                    Console.WriteLine("How sad, the ball has been popped. :\\");
                    ball.Poppedball(true);
                }
                else
                {
                    Console.WriteLine("Im sorry dave, But i cant do that");
                    Console.WriteLine("Please try again, and this time dont be so stupid as the last.");
                    Console.ReadLine();
                }
            }


        }
    }
}
