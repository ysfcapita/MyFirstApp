using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Human // class mother
    {
        private string name; // accessible only here in this class
        public byte age { get; set; } // automatic property creation accessible from the project or outside

        public string nameHandle // normal property declaraation
        {
            get
            {
                return name;
            }
            set
            { 
                name = value; 
            }
        }
        // internal like public but only accessible from the project
        // protected accessible by the class or the classes that inherited it

        public Human()
        {
            age= 0;
            name = "";
        }
        public Human( string name, byte age)
        {
            this.name = name;
            this.age = age;
 
        }

        public void Talk()
        {
            Console.WriteLine("This Human Is Talking");
        }

        public virtual void Work() // virtual key word means that we can override this method in derived classes
        {
            Console.WriteLine("This Human Is Working");
        }

    }
}
