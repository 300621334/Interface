using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    //interface has no fields, <-> abstract class can.
    //and public modifier is not allowed.
    //members can't have any definition. i.e. no block {}. just heading ending e ;.<-> abstract class can have complete methods e a body.
    //by convention start name e 'I' like IFoo instead of Foo.
    //does have inheritence.
    //Why use iface than class. 
    //class if made child of iface it doesn't inherit methods unles we provide for them
    interface IFoo
    {
        int Age { get; }
        void Eat(); //no body {}.
    }

    //child of base:
    interface IBar : IFoo
    { void Drink(int howMuch); }

    interface IBaz
    { void Eat();}

    class Quk : Quuk, IBar , IBaz //cannot have 2 parents e class, but many base ifaces possible.
    {
        public int  Age { get {return 16;} }
        public void Eat() { Console.WriteLine("Eating"); }

        //params have to be exactly as in iface
        public void Drink(int x) { Console.WriteLine("Drinking"); }
        public Quk()
        {
            Console.WriteLine("Hello Interface!"); 
        }
    }

    class Quuk
    {
        public int Name { get; private set; }
    }

}
