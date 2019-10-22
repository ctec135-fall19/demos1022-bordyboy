using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Child : Parent
    {
        // Demonstate overriding a base class method by a child
        public override void SomeMethod()
        {
            Console.WriteLine("Child's SomeMethod");
        }

        //Demostate a child method calling the parent's method
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("Child.Method2");
        }
    }
}
