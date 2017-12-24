using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                //ข้อ1
                Console.Write("in put name of month : ");
                //ประกาศคำสั่ง
                string name = Console.ReadLine();
                //อ่านค่าจากแป้นพิมพ์แล้วนำไปเก็บที่ตัวแปร name เป็นค่า string
                string Jan = ("January"), Feb = ("February"), Mar = ("March"), Apr = ("April"), May = ("May"), Jun = ("June"), Ju = ("July"), Aug = ("August"), Sep = ("September"), Oc = ("October"), Nov = ("November"), Dec = ("December"), jan = ("january"), feb = ("february"), mar = ("march"), apr = ("april"), may = ("may"), jun = ("june"), ju = ("july"), aug = ("august"), sep = ("september"), oc = ("october"), nov = ("november"), dec = ("december"), JAN = ("JANUARY"), FEB = ("FEBRUARY"), MAR = ("MARCH"), APR = ("APRIL"), MAY = ("MAY"), JUN = ("JUNE"), JU = ("JULY"), AUG = ("AUGUST"), SEP = ("SEPTEMBER"), OC = ("OCTOBER"), NOV = ("NOVEMBER"), DEC = ("DECEMBER");
                //กำหนดตัวแปลและเก็บค่าเป็นตัวอักษร
                if (name == jan || name == mar || name == may || name == ju || name == aug || name == oc || name == dec || name == Jan || name == Mar || name == May || name == Ju || name == Aug || name == Oc || name == Dec || name == JAN || name == MAR || name == MAY || name == JU || name == AUG || name == OC || name == DEC)
                //เงื่อนไขในการเช็คค่าใน name ว่าตรงกับเดือนที่มี 31 วันหรือไม่ถ้าไม่ตรงจะข้ามไปที่ else
                { Console.WriteLine("This month has 31 days" + "\n"); }
                //แสดงข้อความหากค่าที่รับมาตรงกับเงื่อนไขแรก
                else if (name == Apr || name == Jun || name == Sep || name == Nov || name == apr || name == jun || name == sep || name == nov || name == APR || name == JUN || name == SEP || name == NOV)
                //เงื่อนไขในการเช็คค่าใน name ว่าตรงกับเดือนที่มี 30 วันหรือไม่ถ้าไม่ตรงจะข้ามไปที่ else
                { Console.WriteLine("This month has 30 days" + "\n"); }
                //แสดงข้อความหากค่าที่รับมาตรงกับเงื่อนไขที่สอง
                else if (name == Feb || name == feb || name == FEB)
                //เงื่อนไขในการเช็คค่าใน name ว่าตรงกับเดือนที่มี 28 หรือ 29 วันหรือไม่ถ้าไม่ตรงจะข้ามไปที่ else
                { Console.WriteLine("This month has 28 or 29 days" + "\n"); }
                //แสดงข้อความหากค่าที่รับมาตรงกับเงื่อนไขที่สาม
                else { Console.WriteLine("Unknown month" + "\n"); }
                //แสดงข้อความหากค่าที่รับมาไม่ตรงตรงกับเงื่อนไขทั้งหมด


                /*//ข้อ2
                Console.Write("in put student score : ");
                //ประกาศคำสั่ง
                double score = double.Parse(Console.ReadLine());
                //รับค่าจากแป้นพิมพ์แล้วนำไปเก็บที่ตัวแปร score เป็นค่า int
                if (score < 0 || score > 100) { Console.WriteLine("Unknown"); }
                //เงื่อนไขแรกหากค่าที่รับมาตํ่ากว่า 0 หรือมากกว่า 100 จะแสดงข้อความ Unknown 
                else if (score < 50) { Console.WriteLine("This student got grade F" + "\n"); }
                //เงื่อนไขที่สองหากค่าที่รับมาตํ่ากว่า 50 จะแสดงข้อความ F แต่หากมากกว่าจะข้ามไปที่ else
                else if (score <= 54) { Console.WriteLine("This student got grade D" + "\n"); }
                //เงื่อนไขที่สามหากค่าที่รับมาตํ่ากว่าหรือเท่ากับ 54 จะแสดงข้อความ D แต่หากมากกว่าจะข้ามไปที่ else
                else if (score <= 59) { Console.WriteLine("This student got grade D+" + "\n"); }
                //เงื่อนไขที่สี่หากค่าที่รับมาตํ่ากว่าหรือเท่ากับ 59 จะแสดงข้อความ D+ แต่หากมากกว่าจะข้ามไปที่ else
                else if (score <= 64) { Console.WriteLine("This student got grade C" + "\n"); }
                //เงื่อนไขที่ห้าหากค่าที่รับมาตํ่ากว่าหรือเท่ากับ 64 จะแสดงข้อความ C แต่หากมากกว่าจะข้ามไปที่ else
                else if (score <= 69) { Console.WriteLine("This student got grade C+" + "\n"); }
                //เงื่อนไขที่หกหากค่าที่รับมาตํ่ากว่าหรือเท่ากับ 69 จะแสดงข้อความ C+ แต่หากมากกว่าจะข้ามไปที่ else
                else if (score <= 74) { Console.WriteLine("This student got grade B" + "\n"); }
                //เงื่อนไขที่เจ็ดหากค่าที่รับมาตํ่ากว่าหรือเท่ากับ 74 จะแสดงข้อความ B แต่หากมากกว่าจะข้ามไปที่ else
                else if (score <= 79) { Console.WriteLine("This student got grade B+" + "\n"); }
                //เงื่อนไขที่แปดหากค่าที่รับมาตํ่ากว่าหรือเท่ากับ 79 จะแสดงข้อความ B+ แต่หากมากกว่าจะข้ามไปที่ else
                else if (score <= 100) { Console.WriteLine("This student got grade A" + "\n"); }
                //เงื่อนไขที่เก้าหากค่าที่รับมาตํ่ากว่าหรือเท่ากับ 100 จะแสดงข้อความ A แต่หากมากกว่าจะข้ามไปที่ else


                //ข้อ3
                Console.WriteLine("calculator");
                //ประกาศชื่อโปรแกรม
                int number1,number2; string Operator;
                //กำหนดตัวแปร
                Console.Write("in put number1 : ");
                //ประกาศให้ใส่ค่าตัวเลขจำนวนที่หนึ่ง
                number1 = int.Parse(Console.ReadLine());
                //อ่านค่าตัวเลขแล้วนำไปเก็บในตัวแปร number1
                Console.Write("in put operator : ");
                //ประกาศคำสั่งให้ใส่ค่าที่เป็น operator คือ +,-,*,/
                Operator = (Console.ReadLine());
                //อ่านค่าแล้วนำไปเก็บที่ตัวแปร Operator
                Console.Write("in put number2 : ");
                //ประกาศให่ใส่ค่าตัวเลขจำนวนที่สอง
                number2 = int.Parse(Console.ReadLine());
                //อ่านค่าตัวเลขแล้วนำไปเก็บที่ตัวแปร number2
                if (Operator == "-") { Console.WriteLine("  =  " + (number1 - number2)); }
                //เงื่อนไขถ้าหากค่าในตัวแปร Operator เป็นเครื่องหมายลบจะแสดงค่าของ number1-number2
                else if (Operator == "+") { Console.WriteLine("  =  " + (number1 + number2)); }
                //เงื่อนไขถ้าหากค่าในตัวแปร Operator เป็นเครื่องหมายบวกจะแสดงค่าของ number1+number2
                else if (Operator == "*") { Console.WriteLine("  =  " + (number1 * number2)); }
                //เงื่อนไขถ้าหากค่าในตัวแปร Operator เป็นเครื่องหมายคูณจะแสดงค่าของ number1*number2
                else if (Operator == "/") { Console.WriteLine("  =  " + (number1 / number2)); }
                //เงื่อนไขถ้าหากค่าในตัวแปร Operator เป็นเครื่องหมายหารจะแสดงค่าของ number1/number2*/

                i++;
            }
        }
    }
}

