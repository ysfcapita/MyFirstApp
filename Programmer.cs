using System;

namespace MyFirstApp
{
    internal class Programmer : Human // class child
    {
        public double Salary { get; set; }

        public Programmer(string n, byte a, double s):base(n,a) // this is how we inherit the constructor
        {
            this.Salary= s;
        }

        public string Infos()
        {
            return $"my name is {this.nameHandle} im {this.age} years old and my salary is {this.Salary}";
        }
        public void Skills (string l)
        {
            Console.WriteLine($"i use {l} programming language");
        }

        public override void Work() // overriding the work() method
        {
            Console.WriteLine("I Work Hard");
        }

        public new void Talk() // it s like overriding but it s created a new method that s called hiding or shadowing
        {
            Console.WriteLine("I Code");
        }
    }
}
