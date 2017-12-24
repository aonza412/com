using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz02
{
    class Program
    {
        static void Main(string[] args)
        {
            double Heart_rate, Respiratory_rate, Intestinal_motion, Fresh_grass, Mineral_salt, Water; string Gum_coloer;
            Console.Write("Heart rate = ");
            Heart_rate = double.Parse(Console.ReadLine());
            if (Heart_rate>=30& Heart_rate <= 40) { Console.WriteLine("normal");}
            else { Console.WriteLine("not normal"); }

            Console.Write("Gum coloer = ");
            Gum_coloer =Console.ReadLine();
            if (Gum_coloer == "pink" | Gum_coloer == "light pink" ) { Console.WriteLine("normal"); }
            else { Console.WriteLine("not normal"); }

            Console.Write("Respiratory rate = ");
            Respiratory_rate = double.Parse(Console.ReadLine());
            if (Respiratory_rate >= 8 & Respiratory_rate <= 24) { Console.WriteLine("normal"); }
            else { Console.WriteLine("not normal"); }

            Console.Write("Intestinal motion = ");
            Intestinal_motion = double.Parse(Console.ReadLine());
            if (Intestinal_motion >= 1 & Intestinal_motion <= 3) { Console.WriteLine("normal"); }
            else { Console.WriteLine("not normal"); }

            Console.Write("Fresh grass per day = ");
            Fresh_grass = double.Parse(Console.ReadLine());
            if (Fresh_grass >= 40 & Fresh_grass <= 50) { Console.WriteLine("normal"); }
            else { Console.WriteLine("not normal"); }

            Console.Write("Mineral salt per day = ");
            Mineral_salt = double.Parse(Console.ReadLine());
            if (Mineral_salt >= 40 & Mineral_salt <= 50) { Console.WriteLine("normal"); }
            else { Console.WriteLine("not normal"); }

            Console.Write("Water per day = ");
            Water = double.Parse(Console.ReadLine());
            if (Water >= 25 & Water <= 100) { Console.WriteLine("normal"); }
            else { Console.WriteLine("not normal"); }





        }
    }
}
