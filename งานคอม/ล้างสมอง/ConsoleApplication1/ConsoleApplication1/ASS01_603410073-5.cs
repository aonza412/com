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
            //ข้อที่1

            /*โปรแกรมข้างล่างนี้ไม่สามารถถอดรูทที่เป็นค่าลบได้ หากมีข้อสอบที่หาค่าได้ก็คำนวนได้แต่หากไม่มีข้อสอบกรุณาให้ a หรือ c ตัวใดตัวหนึ่งเป็นค่าติดลบ 
                 หรือให้ใส่ค่า b เยอะกว่าค่า a และ c  */

            Console.WriteLine("Find value of Squared equation formula is ax^2 - bx + c = 0" + "\n");
            //ประกาศข้อความหัวข้อ สูตร ต่างๆ 

            Console.Write("input value of a : ");
            //แสดงข้อความว่าค่าที่จะใส่คือค่าของ a
            int a = int.Parse(Console.ReadLine());
            //รับค่าที่ใส่ให้แปลงเป็นตัวเลขแล้วนำไปเก็บใน a
            Console.Write("input value of b : ");
            //แสดงข้อความว่าค่าที่จะใส่คือค่าของ b
            int b = int.Parse(Console.ReadLine());
            //รับค่าที่ใส่ให้แปลงเป็นตัวเลขแล้วนำไปเก็บใน b
            Console.Write("input value of c : ");
            //แสดงข้อความว่าค่าที่จะใส่คือค่าของ c
            int c = int.Parse(Console.ReadLine());
            //รับค่าที่ใส่ให้แปลงเป็นตัวเลขแล้วนำไปเก็บใน c

            double x = (-b + Math.Sqrt((Math.Pow(b, 2) - (4 * a * c)))) / (2 * a);
            //เป็นส่วนของสูตรในการคำนวนสมการและนำค่าที่ได้ไปเก็บใน x
            double x_ = (-b - Math.Sqrt((Math.Pow(b, 2) - (4 * a * c)))) / (2 * a);
            //เป็นส่วนของสูตรในการคำนวนสมการและนำค่าที่ได้ไปเก็บใน x
            Console.WriteLine("\n" + "x+ = " + x + "   x- = " + x_ + "\n");
            //แสดงค่าของ x+ และค่า x- ที่ได้จากการคำนวนโดยสูตร



            //ตรงนี้สามาถรบอกได้ว่าแต่ละส่วนคำนวนอย่าไร
            /*  
            Console.WriteLine("Find value of Squared equation formula is ax power2 - bx + c = 0"+"\n");
            

                  Console.Write("input value of a : ");
            
            double a = double.Parse(Console.ReadLine());
            
                  Console.Write("input value of b : ");
            
            double b = double.Parse(Console.ReadLine());
            
            Console.Write("input value of c : ");
            
            double c = double.Parse(Console.ReadLine());
            
            double _b = -b;
            Console.WriteLine("b = " + _b);
            double b2 = Math.Pow(b,2);
            Console.WriteLine("b power2 = " + b2);
            double _4ac = 4 * a * c;
            Console.WriteLine("4ac = " + _4ac);
            double root = Math.Sqrt(b2 - _4ac);
            Console.WriteLine("root = " + root);
            double _2a = 2*a;
            Console.WriteLine("2a = " + _2a);
            double x = (_b + root)/_2a;
            Console.WriteLine("x = " + x);  */



            //ข้อที่2

            Console.WriteLine("\n" + "sale 25%");
            //เป็นข้อความแสดงหัวข้อ
            Console.Write("\n" + "input your price : ");
            //แสดงข้อความว่าค่าที่จะใส่คือค่าของ price
            double price = double.Parse(Console.ReadLine());
            //รับค่าที่ใส่ให้แปลงเป็นตัวเลขแล้วนำไปเก็บใน price
            double discount = price - ((price * 25) / 100);
            //เป็นส่วนของสูตรในการคำนวนสมการและนำค่าที่ได้ไปเก็บใน discount 
            Console.WriteLine("\n" + "total " + discount + " bath" + "\n");
            //แสดงค่าของ discount ที่ได้จากการคำนวนโดยสูตร



            //ข้อที่3

            Console.WriteLine("\n" + "Find the value from the equation x^2+17x+72 = ?" + "\n");
            //เป็นข้อความที่แสดงหัวข้อ
            Console.Write("input value of x : ");
            //เป็นข้อความให้ใส่ค่าของ x
            double _x = double.Parse(Console.ReadLine());
            //รับค่าที่ใส่ให้แปลงเป็นตัวเลขแล้วนำไปเก็บใน x
            double value = (Math.Pow(_x, 2) + (17 * _x)) + 72;
            //เป็นสูตรในการคำนวน แล้วนำไปเก็บไว้ใน value
            Console.WriteLine("\n" + " = " + value + "\n");
            //แสดงค่าของ value ที่ได้จากสูตร

        }
    }
}
