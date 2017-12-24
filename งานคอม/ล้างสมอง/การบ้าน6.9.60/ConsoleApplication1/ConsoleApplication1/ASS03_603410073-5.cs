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
            //********** คำสั่ง break; คือคำสั่งหยุด ************
            string a; //ประกาศตัวแปร ที่ใช้ในการเช็คค่าของ loop do while แรก
            do //คำสั่ง loop
            {
                Console.WriteLine("\n\n When you want to exit pleas in put “out” in In put number of game text field.");
                //ประกาศข้อความแจ้งว่าถ้าต้องการออกจาก loop ให้พิมว่า out 
                Console.WriteLine(" -----GAME Rock Paper Scissors----in put 1");
                //ประกาศชื่อเกมแรก
                Console.WriteLine(" ------------Calculator-----------in put 2");
                //ประกาศชื่อเกมที่สอง
                Console.WriteLine(" ---Calculator G.C.D and L.C.M----in put 3");
                //ประกาศชื่อเกมสาม
                Console.WriteLine(" ----------Pokemon Game-----------in put 4");
                //ประกาศชื่อเกมที่สี่
                Console.Write(" In put number of game : ");
                //ประกาศคำสั่งให้ใส่ลำดับของเกมที่ต้องการเล่น
                a = Console.ReadLine();
                //คำสั่งอ่านค่าแล้วเอาไปเก็บในตัวแปร a
                switch (a) //สวิชของตัวแปร a
                {
                    case "1": //กรณีที่ a = 1 จะทำตามโปรแกรมด้านล่างนี้
                        string Player1, Player2; //ประกาศตัวแปร string ชื่อ Player1 และ Player2
                        do //คำสั่ง loop
                        {
                            Console.WriteLine("\n\n When you want to exit pleas in put “out” in Player1 text field.");
                            //ประกาศข้อความแจ้งว่าถ้าต้องการออกจาก loop ให้พิมว่า out 
                            Console.WriteLine(" ---GAME Rock Paper Scissors---");
                            //ประกาศชื่อเกม
                            Console.WriteLine(" -----In put your posture-----");
                            //ประกาศคำสั่งให้ใส่ชื่อท่า
                            Console.Write(" Player1 : ");
                            //ประกาศว่าค่าที่ใส่คือค่าของ Player1
                            Player1 = Console.ReadLine();
                            //อ่านค่าแล้วนำไปเก็บที่ตัวแปล Player1
                            if (Player1 != "out") //คำสั่งในการเช็คว่าค่าที่รับเข้ามาไม่ตรงกับคำว่า out ก็จะทำคำสั่งในวงเล็บปีกกา
                            {
                                Console.Write(" Player2 : ");
                                //ประกาศว่าค่าที่ใส่คือค่าของ Player1
                                Player2 = Console.ReadLine();
                                //อ่านค่าแล้วนำไปเก็บที่ตัวแปล Player1
                                switch (Player1) //สวิชของตัวแปร Player1
                                {
                                    case "Rock": //หากค่าที่รับมาตรงกับคำว่า Rock จะทำตามคำสั่งข้างล่าง
                                        switch (Player2) //สวิชของตัวแปร Player2
                                        {
                                            case "Rock": Console.WriteLine(" Draw!!!"); break;
                                            //หาก Player1 เป็น Rock และ Player2 เป็น Rock จะแสดงข้อความว่า Draw!!!
                                            case "Paper": Console.WriteLine(" Win!!!"); break;
                                            //หาก Player1 เป็น Rock และ Player2 เป็น Paper จะแสดงข้อความว่า Win!!!
                                            case "Scissors": Console.WriteLine(" Lose!!!"); break;
                                            //หาก Player1 เป็น Rock และ Player2 เป็น Scissors จะแสดงข้อความว่า Lose!!!
                                            default: Console.WriteLine(" Unknow"); break;
                                            //หาก Player1 เป็น Rock และ Player2 ไม่ตรงกับเงื่อนไขจะแสดงข้อความว่า Unknow
                                        }
                                        break;
                                    case "Paper": //หากค่าที่รับมาตรงกับคำว่า Paper จะทำตามคำสั่งข้างล่าง
                                        switch (Player2) //สวิชของตัวแปร Player2
                                        {
                                            case "Rock": Console.WriteLine(" Lose!!!"); break;
                                            //หาก Player1 เป็น Paper และ Player2 เป็น Rock จะแสดงข้อความว่า Lose!!!
                                            case "Paper": Console.WriteLine(" Draw!!!"); break;
                                            //หาก Player1 เป็น Paper และ Player2 เป็น Paper จะแสดงข้อความว่า Draw!!!
                                            case "Scissors": Console.WriteLine(" Win!!!"); break;
                                            //หาก Player1 เป็น Paper และ Player2 เป็น Scissors จะแสดงข้อความว่า Win!!!
                                            default: Console.WriteLine(" Unknow"); break;
                                            //หาก Player1 เป็น Paper และ Player2 ไม่ตรงกับเงื่อนไขจะแสดงข้อความว่า Unknow
                                        }
                                        break;
                                    case "Scissors"://หากค่าที่รับมาตรงกับคำว่า Scissors จะทำตามคำสั่งข้างล่าง
                                        switch (Player2) //สวิชของตัวแปร Player2
                                        {
                                            case "Rock": Console.WriteLine(" Win!!!"); break;
                                            //หาก Player1 เป็น Scissors และ Player2 เป็น Rock จะแสดงข้อความว่า Win!!!
                                            case "Paper": Console.WriteLine(" Lose!!!"); break;
                                            //หาก Player1 เป็น Scissors และ Player2 เป็น Paper จะแสดงข้อความว่า Lose!!!
                                            case "Scissors": Console.WriteLine(" Draw!!!"); break;
                                            //หาก Player1 เป็น Scissors และ Player2 เป็น Scissors จะแสดงข้อความว่า Draw!!!
                                            default: Console.WriteLine(" Unknow"); break;
                                            //หาก Player1 เป็น Paper และ Player2 ไม่ตรงกับเงื่อนไขจะแสดงข้อความว่า Unknow
                                        }
                                        break;
                                    default: Console.WriteLine("Unknow"); break;//หากค่าที่รับมาไม่ตรงกับกรณีใดเลยจะแสดงข้อความ Unknow
                                }
                            }
                        } while (Player1 != "out"); break;//หากใส่คำว่า out ที่ช่อง Player1 จะออกจา loop เกมนี้
                    case "2"://กรณีที่ a = 2 จะทำตามโปรแกรมด้านล่างนี้
                        string calculation, _first, _second; double first, second;
                        //ประกาศตัวแปรที่จะใช้ในโปรแกรมด้านล่างนี้
                        do //คำสั่ง loop
                        {
                            Console.WriteLine("\n\n When you want to exit pleas in put “out” in calculation text field.");
                            //ประกาศข้อความแจ้งว่าถ้าต้องการออกจาก loop ให้พิมว่า out 
                            Console.WriteLine(" -------------Calculator-------------");
                            //ประกาศชื่อเกม
                            Console.WriteLine(" You can Calculate : + - * / % ^ root ");
                            //แสดงข้อความแจ้งว่าคุณสามารถคำนวนอะไรได้บ้าง
                            Console.WriteLine(" In second number it is power and root of function ^ and root");
                            //แสดงข้อความแจ้งเตือนว่า ในช่องใส่ตัวเลขที่ 2 จะเป็นตัวชี้กำลังและรากที่เท่าไหร่
                            Console.Write(" Mark in the calculation : ");
                            //ประกาศคำสั่งให้ใส่เครื่องหมายในการคำนวน
                            calculation = Console.ReadLine();
                            //อ่านค่าแล้วนำไปเก็บในตัวแปร calculation
                            if (calculation != "out") //คำสั่งในการเช็คว่าค่าที่รับเข้ามาไม่ตรงกับคำว่า out ก็จะทำคำสั่งในวงเล็บปีกา
                            {
                                Console.Write(" In put your first number : ");
                                //ประกาศคำสั่งให้ใส่ค่าตัวเลขตัวแรก
                                _first = Console.ReadLine();
                                //อ่านค่าแล้วนำไปเก็บที่ตัวแปร _first
                                Console.Write(" In put your second number : ");
                                //ประกาศคำสั่งให้ใส่ค่าตัวเลขตัวที่สอง
                                _second = Console.ReadLine();
                                //อ่านค่าแล้วนำไปเก็บที่ตัวแปร _second
                                bool first_ = double.TryParse(_first, out first);
                                //คำสั่งเช็คว่าค่าใน _first เป็นตัวเลขแล้วนำไปเก็บใน first ได้มั้ย โดยแบ่งเป็น จริง,เท็จ หรือ true,false
                                bool second_ = double.TryParse(_second, out second);
                                //คำสั่งเช็คว่าค่าใน _second เป็นตัวเลขแล้วนำไปเก็บใน second ได้มั้ย โดยแบ่งเป็น จริง,เท็จ หรือ true,false
                                switch (first_ & second_)
                                //สวิชเช็คค่าว่า first_ และ second_ เป็นจริงมั้ย 
                                {
                                    case true://กรณีที่เป็นจริงทั้งคู่จะทำคำสั่งด้านล่าง
                                        switch (calculation)//สวิชของตัวแปร calculation
                                        {
                                            case "+": Console.WriteLine(" {0} + {1}  = " + (first + second), first, second); break;
                                            //กรณีที่ค่าของ calculation ตรงกับ + จะแสดงผลลัพธ์ของ first + second
                                            case "-": Console.WriteLine(" {0} - {1}  = " + (first - second), first, second); break;
                                            //กรณีที่ค่าของ calculation ตรงกับ - จะแสดงผลลัพธ์ของ first - second
                                            case "*": Console.WriteLine(" {0} * {1}  = " + (first * second), first, second); break;
                                            //กรณีที่ค่าของ calculation ตรงกับ * จะแสดงผลลัพธ์ของ first * second
                                            case "%": Console.WriteLine(" {0} % {1}  = " + (first % second), first, second); break;
                                            //กรณีที่ค่าของ calculation ตรงกับ % จะแสดงผลลัพธ์ของ first % second
                                            case "^": Console.WriteLine(" {0} ^ {1}  = " + (Math.Pow(first, second))); break;
                                            //กรณีที่ค่าของ calculation ตรงกับ ^ จะแสดงผลลัพธ์ของ first ยกกำลังด้วย second
                                            case "root": Console.WriteLine(" {0} root {1}  = " + Math.Round(Math.Pow(first, 1 / second), 4 ), first, second); break;
                                            //กรณีที่ค่าของ calculation ตรงกับ root จะแสดงผลลัพธ์ของ first ยกกำลังด้วย 1/second
                                            default: Console.WriteLine(" Unknow"); break;
                                            //กรณีที่ค่าของ calculation ไม่ตรงกับกรณีใดเลยจะแสดงข้อความ Unknow
                                        }
                                        break;
                                    case false: Console.WriteLine(" Unknow"); break;
                                    //กรณีที่เป็นเท็จทั้งคู่จะแสดงข้อความ Unknow
                                }
                            }
                        } while (calculation != "out"); break;//หากใส่คำว่า out ที่ช่อง calculation จะออกจา loop เกมนี้
                    case "3": //กรณีที่ a = 3 จะทำตามโปรแกรมด้านล่างนี้
                        int c, d, e, f, g, h, i, j; string firstnum, secondnum;
                        //ประกาศตัวแปรที่จะใช้ในโปรแกรมด้านล่างนี้
                        do //คำสั่ง loop
                        {
                            Console.WriteLine("\n\n When you want to exit pleas in put “out” in first number text field.");
                            //ประกาศข้อความแจ้งว่าถ้าต้องการออกจาก loop ให้พิมว่า out 
                            Console.WriteLine(" ----------Calculator G.C.D and L.C.M----------");
                            //ประกาศชื่อเกม
                            Console.Write(" In put your first number : ");
                            //ประกาศคำสั่งให้ใส่ค่าตัวเลขตัวแรก
                            firstnum = Console.ReadLine();
                            //อ่านค่าแล้วนำไปเก็บในตัวแปร firstnum
                            if (firstnum != "out") //คำสั่งในการเช็คว่าค่าที่รับเข้ามาไม่ตรงกับคำว่า out ก็จะทำคำสั่งในวงเล็บปีกา
                            {
                                Console.Write(" In put your second number : ");
                                //ประกาศคำสั่งให้ใส่ค่าตัวเลขตัวที่สอง
                                secondnum = Console.ReadLine();
                                //อ่านค่าแล้วนำไปเก็บในตัวแปร secondnum
                                bool x = int.TryParse(firstnum, out c); bool y = int.TryParse(secondnum, out d);
                                //คำสั่งเช็คว่าค่าใน firstnum และ secondnum ว่าเป็นตัวเลขแล้วนำไปเก็บใน c และ d ได้มั้ย โดยแบ่งเป็น จริง,เท็จ หรือ true,false
                                h = c; j = d;
                                //กำหนดให้ h มีค่าเท่ากับ c และกำหนดให้ j มีค่าเท่ากับ d
                                switch (x & y)
                                //สวิชเช็คค่าว่า x และ y เป็นจริงมั้ย
                                {
                                    case true://กรณีที่เป็นจริงทั้งคู่จะทำคำสั่งด้านล่าง
                                        for (i = 0; j != 0; i++)//คำสั่ง loop โดยจะออกก็ต่อเมื่อ d = 0
                                        {
                                            e = j; //กำหนดให้ e มีค่าเท่ากับ d
                                            j = c % j; //นำ c มาตั้งแล้วหารด้วย j จากนั้นเอาเศษ มาแทนที่ j 
                                            c = e; //กำหนดให้ c มีค่าเท่ากับ e ซึ่งในคำสั่งนี้จะทำให้รอบต่อไป c มีค่าลดลง ทำให้ j = 0
                                        }
                                        f = (h * d) / c; //เป็นสูตรในการหา ครน. คือการนำค่าที่ต้องการหามาคูณกันแล้วหารด้วย หรม.
                                        Console.WriteLine(" G.C.D = " + c);
                                        //แสดงค่าของ หรม.
                                        Console.WriteLine(" L.C.M = " + f); break;
                                        //แดงค่าของ ครน.
                                    case false: Console.WriteLine(" Unknow"); break;
                                    //กรณีที่เป็นเท็จทั้งคู่จะแสดงข้อความ Unknow
                                }
                            }
                        } while (firstnum != "out"); break;//หากใส่คำว่า out ที่ช่อง firstnum จะออกจา loop เกมนี้
                    case "4": //กรณีที่ a = 4 จะทำตามโปรแกรมด้านล่างนี้
                        string name_skill; int HP = 1000, IronHead = 80, Psybeam = 65, AuroraBeam = 65, SolarBeam = 120, DazzlingGleam = 80, VoltSwitch = 70;
                        //กำหนดชื่อตัวแปรและกำหนดค่าของตัวแปรบางตัว
                        Console.WriteLine("\n\n When you want to exit pleas in put “out” in name of skill text field.");
                        //ประกาศข้อความแจ้งว่าถ้าต้องการออกจาก loop ให้พิมว่า out 
                        Console.WriteLine(" -------Pokemon Game---------");
                        //ประกาศชื่อเกม
                        Console.WriteLine(" ---Player VS Magearna---");
                        //แสดงข้อความว่า ผู้เล่นสู้กับโปเกมอนที่ชื่อ Magearna
                        Console.WriteLine(" List name skill you can coppy : IronHead,Psybeam,AuroraBeam,SolarBeam,DazzlingGleam and VoltSwitch\n");
                        //แสดงชื่อท่าไม้ตายที่ใช้ได้
                        do//คำสั่ง loop
                        {
                            Console.Write(" Enter name of skill : ");
                            //ข้อความให้ใส่ชื่อท่า
                            name_skill = Console.ReadLine();
                            //คำสั่งอ่านค่าและนำไปเก็บที่ตัวแปร name_skill
                            if (name_skill != "out") //คำสั่งในการเช็คว่าค่าที่รับเข้ามาไม่ตรงกับคำว่า out ก็จะทำคำสั่งในวงเล็บปีกา
                            {
                                switch (name_skill)//สวิชของตัวแปร name_skill
                                {
                                    case "IronHead": HP -= IronHead; Console.WriteLine(" Atk of skill : " + IronHead); break;
                                    //หากค่าในตัวแปร name_skill = IronHead จะนำเลือดของมอนสเตอร์ มาลบกับค่าที่กำหนดแล้วแสดงค่าพลังโจมตี
                                    case "Psybeam": HP -= Psybeam; Console.WriteLine(" Atk of skill : " + Psybeam); break;
                                    //หากค่าในตัวแปร name_skill = Psybeam จะนำเลือดของมอนสเตอร์ มาลบกับค่าที่กำหนดแล้วแสดงค่าพลังโจมตี
                                    case "AuroraBeam": HP -= AuroraBeam; Console.WriteLine(" Atk of skill : " + AuroraBeam); break;
                                    //หากค่าในตัวแปร name_skill = AuroraBeam จะนำเลือดของมอนสเตอร์ มาลบกับค่าที่กำหนดแล้วแสดงค่าพลังโจมตี
                                    case "SolarBeam": HP -= SolarBeam; Console.WriteLine(" Atk of skill : " + SolarBeam); break;
                                    //หากค่าในตัวแปร name_skill = SolarBeam จะนำเลือดของมอนสเตอร์ มาลบกับค่าที่กำหนดแล้วแสดงค่าพลังโจมตี
                                    case "DazzlingGleam": HP -= DazzlingGleam; Console.WriteLine(" Atk of skill : " + DazzlingGleam); break;
                                    //หากค่าในตัวแปร name_skill = DazzlingGleam จะนำเลือดของมอนสเตอร์ มาลบกับค่าที่กำหนดแล้วแสดงค่าพลังโจมตี
                                    case "VoltSwitch": HP -= VoltSwitch; Console.WriteLine(" Atk of skill : " + VoltSwitch); break;
                                    //หากค่าในตัวแปร name_skill = VoltSwitch จะนำเลือดของมอนสเตอร์ มาลบกับค่าที่กำหนดแล้วแสดงค่าพลังโจมตี
                                    case "IPASDV": HP -= 1000; Console.WriteLine(" Atk of skill : " + 1000); break;
                                    //หากค่าในตัวแปร name_skill = IPASDV จะนำเลือดของมอนสเตอร์ มาลบกับค่าที่กำหนดแล้วแสดงค่าพลังโจมตี (สูตรโกง)
                                    default: Console.WriteLine(" Atk of skill : Unkonw"); break;
                                    //หากค่าในตัวแปร name_skill ไม่ตรงกับชื่อท่าใดเลยจะแสดงข้อความว่า Atk of skill : Unkonw
                                }
                                if (HP > 0)//คำสั่งในการเช็คว่าค่าของ HP มากว่า 0 มั้ย หากมากกว่าจะแสดงข้อความด้านล่าง
                                    Console.WriteLine(" HP of Magearna is : " + HP + "\n");
                                    //แสดงข้อความว่าเลือดของมอนสเตอร์เหลือเท่าไหร่
                                else if (HP <= 0)//คำสั่งในการเช็คว่าค่าของ HP น้อยกว่าหรือเท่ากับ 0 มั้ย หากน้อยกว่าหรือเท่ากับจะแสดงข้อความด้านล่าง
                                {
                                    Console.WriteLine(" HP of Magearna is : 0"+"\n\n YOU WIN!!!\n");
                                    //แสดงข้อความว่ามอนสเตอร์เลือดเหลือ 0 และแสดงข้อความว่าคุณชนะ
                                }
                            }
                        } while (HP > 0); break;//เงื่อนไขโดยเช็คว่าถ้า HP น้อยกว่าหรือเท่ากับ 0 ให้ออกจากเกม
                }
            } while (a != "out");//เงื่อนไขหาก a = out จะออกจากโปรแกรม
        }
    }
}
