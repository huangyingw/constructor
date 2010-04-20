using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Polymorphism
//seal,new,abstract
namespace csharp
{
    struct MyStruct
    {
        private int num;    
    }

    interface ISampleInterface
    {
        //inheritance must implement this method
        //Could not implement here
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
    sealed class C : B
    {
    }
    abstract class D:B
    {
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
