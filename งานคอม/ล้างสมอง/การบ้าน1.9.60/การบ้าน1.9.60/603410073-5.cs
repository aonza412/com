using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้าน1._9._60
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 i,b,d;string a;
            do
            {
                Console.Write("in put factorial : ");
                a = Console.ReadLine();
                bool c = Int64.TryParse(a, out b);
                d = b;

                switch (c)
                {
                    case true:
                        if (d == 0)
                        {
                            Console.WriteLine(b + "! = 1");
                        }
                        else if (d >= 0 & d <= 20)
                        {
                            for (i = 1; i < b; i++)
                            {
                                d = d * i;
                            }
                            Console.WriteLine(b + "! = " + d);
                        }
                        else
                        {
                            Console.WriteLine(b + " = NAN");
                        }; break;
                    case false: if (a != "exit") { Console.WriteLine("try agian"); } ;break;
                }
                /*if (c)
                {
                    if (d == 0)
                    {
                        Console.WriteLine(b + "! = 1");
                    }
                    else if(d>=0&d<=20)
                    {
                        for (i = 1; i < b; i++)
                        {
                            d = d * i;
                        }
                        Console.WriteLine(b + "! = " + d);
                    }
                    else
                    {
                        Console.WriteLine(b+" = NAN");
                    }
                }
                else if(a!="exit"){ Console.WriteLine("try agian"); }*/

            } while (a != "exit");
            //ยาวกว่านี้ทำไม่เป็นคับ ได้แค่ 20! คับ
        }
    }
}
