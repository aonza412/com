using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ข้อ1
            Console.Write(" Month : ");
            //แสดง Month
            string Month = Console.ReadLine();
            //กำหนดจากแป้นพิมพ์แล้วนำไปเก็บที่ตัวแปร Month เป็นค่า string
            string Jan = ("January"), Feb = ("February"), Mar = ("March"), Apr = ("April"), May = ("May"), Jun = ("June"), Ju = ("July"), Aug = ("August"), Sep = ("September"), Oc = ("October"), Nov = ("November"), Dec = ("December");
            //กำหนดตัวแปลและเก็บค่าเป็นตัวอักษร
            if (Month == Jan || Month == Mar || Month == May || Month == Ju || Month == Aug || Month == Oc || Month == Dec)
            //เงื่อนไขใน Month ว่าเดือนที่มี 31 วันหรือไม่ถ้าไม่ตรงจะข้ามไปที่ else
            { Console.WriteLine("This month has 31 days" + "\n"); }
            //แสดงข้อความหากค่าที่รับมาตรงกับเงื่อนไขแรก
            else if (Month == Apr || Month == Jun || Month == Sep || Month == Nov )
            //เงื่อนไขใน Month ว่าเดือนที่มี 30 วันหรือไม่ถ้าไม่ตรงจะข้ามไปที่ else
            { Console.WriteLine("This month has 30 days"  ); }
            //แสดงข้อความหากค่าที่รับมาตรงกับเงื่อนไขที่สอง
            else if (Month == Feb )
            //เงื่อนไขใน Month ว่าตรงกับเดือนที่มี 28 หรือ 29 วันหรือไม่ถ้าไม่ตรงจะข้ามไปที่ else
            { Console.WriteLine("This month has 28 or 29 days" + "\n"); }
            //แสดงข้อความหากค่าที่รับมาตรงกับเงื่อนไขที่สาม
            else { Console.WriteLine("Unknown month" + "\n"); }
            //แสดงข้อความหากค่าที่รับมาไม่ตรงกับเงื่อนไขของ Month ทั้งหมด */
            
            //ข้อ2
           
            Console.Write("Nuber Score: ");
            //แสดง Nuber Score
            double Score = double.Parse(Console.ReadLine());
            //กำหนดแล้วนำไปเก็บที่ตัวแปร score เป็นค่า int
            if (Score < 0 || Score > 100) { Console.WriteLine("Unknown"); }
            //เงื่อนไขที่1ค่าที่รับมาตํ่ากว่า 0 หรือมากกว่า 100 จะแสดง Unknown 
            else if (Score >=80 && Score <= 100) { Console.WriteLine("You got a grade A" + "\n"); }
            //เงื่อนไขที่2ค่าที่รับมาตํ่ากว่าหรือเท่ากับ 100 จะแสดงข้อความ A แต่มากกว่าจะข้ามไปที่ else
            else if (Score >= 79) { Console.WriteLine("You got a grade B+" + "\n"); }
            //เงื่อนไขที่สามค่าที่รับมาตํ่ากว่าหรือเท่ากับ 79 จะแสดงข้อความ B+ แต่มากกว่าจะข้ามไปที่ else
            else if (Score >= 74) { Console.WriteLine("You got a grade B" + "\n"); }
            //เงื่อนไขที่4ค่าที่รับมาตํ่ากว่าหรือเท่ากับ 74 จะแสดงข้อความ B แต่มากกว่าจะข้ามไปที่ else
            else if (Score >= 69) { Console.WriteLine("You got a grade C+" + "\n"); }
            //เงื่อนไขที่5ค่าที่รับมาตํ่ากว่าหรือเท่ากับ 69 จะแสดงข้อความ C+ แต่มากกว่าจะข้ามไปที่ else
            else if (Score >= 64) { Console.WriteLine("You got a grade C" + "\n"); }
            //เงื่อนไขที่6ค่าที่รับมาตํ่ากว่าหรือเท่ากับ 64 จะแสดงข้อความ C แต่มากกว่าจะข้ามไปที่ else
            else if (Score >= 59) { Console.WriteLine("You got a grade D+" + "\n"); }
            //เงื่อนไขที่7ค่าที่รับมาตํ่ากว่าหรือเท่ากับ 59 จะแสดงข้อความ D+ แต่มากกว่าจะข้ามไปที่ else
            else if (Score >= 54) { Console.WriteLine("You got a grade D" + "\n"); }
            //เงื่อนไขที่8หากค่าที่รับมาตํ่ากว่าหรือเท่ากับ 54 จะแสดงข้อความ D แต่หากมากกว่าจะข้ามไปที่ else
            else if (Score < 50) { Console.WriteLine("You got a grade F" + "\n"); }
            //เงื่อนไขที่9ค่าที่รับมาตํ่ากว่า 50 จะแสดงข้อความ F แต่มากกว่าจะข้ามไปที่ else */

           
            //ข้อ3
            Console.WriteLine("Calculator");
            //แสดง Calculator
            int Number1, Number2; string Operator;
            //กำหนดค่า
            Console.Write("Number1 : ");
            //แสดงให้ใส่ค่าตัวเลขจำนวนที่หนึ่ง
            Number1 = int.Parse(Console.ReadLine());
            //กำหนดตัวเลขแล้วนำไปเก็บในตัวแปร number1
            Console.Write(" Operator : ");
            //ประกาศคำสั่งให้ใส่ค่าที่เป็น operator คือ +,-,*,/
            Operator = (Console.ReadLine());
            //กำหนดแล้วนำไปเก็บที่ตัวแปร Operator
            Console.Write(" Number2 : ");
            //แสดงให่ใส่ค่าตัวเลขจำนวนที่สอง
            Number2 = int.Parse(Console.ReadLine());
            //กำหนดตัวเลขแล้วนำไปเก็บที่ตัวแปร Number2
            if (Operator == "-") { Console.WriteLine("  =  " + (Number1 - Number2)); }
            //เงื่อนไขถ้า ค่าใน Operator เป็นเครื่องหมายลบจะแสดงค่าของ Number1-Number2
            else if (Operator == "+") { Console.WriteLine("  =  " + (Number1 + Number2)); }
            //เงื่อนไขถ้า ค่าใน Operator เป็นเครื่องหมายบวกจะแสดงค่าของ Number1+Number2
            else if (Operator == "*") { Console.WriteLine("  =  " + (Number1 * Number2)); }
            //เงื่อนไขถ้า ค่าใน Operator เป็นเครื่องหมายคูณจะแสดงค่าของ Number1*Number2
            else if (Operator == "/") { Console.WriteLine("  =  " + (Number1 / Number2)); }
            //เงื่อนไขถ้า ค่าใน Operator เป็นเครื่องหมายหารจะแสดงค่าของ Number1/Number2
        }
    }
}
