using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor
{
    class A
    {
        public void SampleMethod()
        {
        }
    }
    class B : A
    {
        virtual public void MyVir()
        {
        }
    }
    sealed class C : B
    {
    }
    abstract class D : B
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
                    }
    }
}
