// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Console;
using static System.Convert;

namespace MyFirstApp
{
    class Program
    {
        static Programmer a = new Programmer("youssef",27,100000);
        static Human y = new Human();
        static Human b = new Human("belghiti", 27);
        static int PassByRef(ref int num)
        {
            int mult = num * 2;
            return mult;
        }
        static void ShowName(string name)
        {

            WriteLine($"your name is {name}");

        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        const double PI = 3.14; // Constant
        enum Level // CREATED TO STORE PERMANENT VALUES (CONSTANTS).
        {
            Easy,
            Medium,
            hard
        }

        struct Student // Structures are near to the concept of a Class
        {
            public string name;
            public byte age;
            public string address;

            public Student(string a, byte b, string c)
            {
                name = a;
                age = b;
                address = c;
            }

        }
        static void Main(String[] args)
        {
            //byte a = 28;
            //string y = "youssef";
            //// System.Console.WriteLine("my name is {0} and MyFirstApp age is {1}", y,a);

            //// String interpolation  
            //Console.WriteLine($"my name is {y} and my age is {a}");


            /***********************************************************************************/

            //string name;
            //byte age;


            //Console.WriteLine("Enter Your Name: ");

            //name = Console.ReadLine().ToUpper();

            //Console.WriteLine($"Your Name Is: '{name}'\n");

            //Console.WriteLine("Enter Your Age: ");

            //age = Convert.ToByte(Console.ReadLine());

            //Console.WriteLine($"Your Age Is: '{age}'");

            /***********************************************************************************/

            //byte num;

            //Console.WriteLine($"Is that can be divided by 3 ?");

            //num = Convert.ToByte(Console.ReadLine());

            //if (num % 3 == 0 ) {

            //    Console.WriteLine("yes".ToUpper());

            //} else
            //{

            //    Console.WriteLine("no".ToUpper());  
            //}

            /***********************************************************************************/


            //int[,] a = new int[2, 3];
            //int b = 0;

            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        a[i, j] = b;
            //        b++;
            //    }
            //}

            //foreach(var c in a)
            //{
            //    Console.WriteLine(c);
            //}

            /***********************************************************************************/

            //double price = 123123894.12;

            //WriteLine($"{price:c}");

            /***********************************************************************************/

            //DateTime date = DateTime.Now;

            //WriteLine($"{date:d}");
            //WriteLine($"{date:dd}");
            //WriteLine($"{date:mm}");
            //WriteLine($"{date:MM}");
            //WriteLine($"{date:yyyy}");
            //WriteLine($"{date:MM/yyyy}");
            //WriteLine($"{date:yyyy/MM/dd}");
            //WriteLine($"{date:hh/mm/ss}");

            /***********************************************************************************/

            //ShowName("youssef");
            //WriteLine(Add(1,2));

            /***********************************************************************************/

            //int num = 3;
            //WriteLine(num);
            //WriteLine(PassByRef(ref num));
            //WriteLine(num);

            /***********************************************************************************/


            //int age;

            //a: WriteLine("inter your age:");
            //try
            //{
            //    age = ToInt32(ReadLine());
            //    WriteLine($"your age is {age}");
            //}
            //catch (FormatException ex)
            //{

            //    WriteLine($"is not an integer {ex.Message}");
            //    goto a;

            //}
            //catch (OverflowException ex)
            //{

            //    WriteLine($"is too large {ex.Message}");
            //    goto a;

            //}
            //catch (Exception ex)
            //{

            //    WriteLine($"is not valid {ex.Message}");
            //    goto a;

            //}

            //finally
            //{
            //    WriteLine("Wish You A Good Day");
            //}

            /***********************************************************************************/

            //Level level = Level.Easy;
            //WriteLine($"YOUR LEVEL NOW IS : {level}");
            //int number;
            //do
            //{
            //    WriteLine("Guess a number: ");
            //    number = ToInt32(ReadLine());
            //} while (number != 5);
            //WriteLine("You Win !!!");
            //level++;
            //WriteLine($"YOUR LEVEL NOW IS : {level}");

            /***********************************************************************************/

            //Student std = new Student("Youssef Belghiti", 27, "meknes");

            //WriteLine(std.name);

            /***********************************************************************************/

            //byte i = byte.MaxValue;
            //i++;
            //WriteLine($"{i}");

            /***********************************************************************************/

            //y.nameHandle = "youssef";
            //WriteLine($"{y.nameHandle}   {b.nameHandle}");
            //y.Talk();

            /***********************************************************************************/

            //a.Skills("C#");
            //WriteLine(a.Infos());
            //y.Work();
            //a.Work();
            //y.Talk();
            //a.Talk();

            /***********************************************************************************/

        }

    }
}





