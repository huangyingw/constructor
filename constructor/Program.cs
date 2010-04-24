using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor
{
    class A
    {
        public A()
        {
            Console.WriteLine("A()");
        }
        ~A()
        {
            Console.WriteLine("~A()");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("B()");
        }
        ~B()
        {
            Console.WriteLine("~B()");
        }
    }
    sealed class C : B
    {
        public C()
        {
            Console.WriteLine("C()");
        }
        ~C()
        {
            Console.WriteLine("~C()");
        }
    }
    abstract class D : B
    {
        public D()
        {
            Console.WriteLine("D()");
        }
        ~D()
        {
            Console.WriteLine("~D()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            //D d = new D();

        }
    }
}
