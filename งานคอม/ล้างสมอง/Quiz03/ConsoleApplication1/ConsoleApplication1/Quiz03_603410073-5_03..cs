using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            string item; int a = 0, b = 0, c = 0, d = 0, x;
            do
            {
                Console.WriteLine("  -------Stamp calculator-------");
                Console.Write("  Name of Product : ");
                item = Console.ReadLine();
                if (item != "s")
                {
                    Console.Write("  In put amount : ");
                    x = int.Parse(Console.ReadLine());

                    if (item == "ProtexCoolingPowder" | item == "SunsilkShampoo") //ProtexCoolingPowder,SunsilkShampoo
                    {
                        a += 9 * x;
                    }
                    else if (item == "RollOn" | item == "ChlormintCandy")//RollOn,ChlormintCandy
                    {
                        a += 12 * x;
                    }
                    else if (item == "ScotchBird'Nest")//ScotchBird'Nest
                    {
                        a += 15 * x;
                    }
                    else if (item == "NIVEAMenFoam")//NIVEAMenFoam
                    {
                        a += 18 * x;
                    } 
                } 
            } while (item != "s");
                Console.WriteLine("  total Stamp = " + a );
        }
    }
}


