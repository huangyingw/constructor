using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Polymorphism
namespace csharp
{
    interface ISampleInterface
    {
        //inheritance must implement this method
        void SampleMethod();
    }


    class A : ISampleInterface
    {
        public void SampleMethod()
        { 
        }
    }
    class B : A
    {
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
