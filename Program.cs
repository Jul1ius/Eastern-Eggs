using System;

namespace Eastern_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());

            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;

            string colorOfMaxEggs = " ";
            int maxEggs = int.MinValue;

            for (int i = 0; i <= eggs; i++)
            {
                string eggColor = Console.ReadLine();

                switch (eggColor)
                {
                    case "red":
                        red++; 
                        if (red > maxEggs)
                        {
                            maxEggs = red;
                            colorOfMaxEggs = "red";
                        }
                        break;
                    case "orange":
                        orange++;
                        if (orange > maxEggs)
                        {
                            maxEggs = orange;
                            colorOfMaxEggs = "orange";
                        }
                        break;
                    case "blue":
                        blue++;
                        if (blue > maxEggs)
                        {
                            maxEggs = blue;
                            colorOfMaxEggs = "blue";
                        }
                        break;
                          
                    case "green":
                        green++;
                        if (green > maxEggs)
                        {
                            maxEggs = green;
                            colorOfMaxEggs = "green";
                        }
                        break;
                }
            }
            Console.WriteLine($"Red eggs:{red}");
            Console.WriteLine($"Orange eggs:{orange}");
            Console.WriteLine($"Blue eggs:{blue}");
            Console.WriteLine($"Green eggs:{green}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {colorOfMaxEggs}");
        }
    }
}
