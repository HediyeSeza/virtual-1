using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_1
{
    internal class Class2:Class1
    {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
        public override void sayHello()
        {
            base.sayHello();
            Console.WriteLine("Hello World ...");
           
        }
    }
}
