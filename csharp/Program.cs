using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Polymorphism
//seal,new,abstract, container
//override operator, 
//implement the method to sort and compare in List<T>
namespace csharp
{
    struct MyStruct
    {
        private int num;
        public MyStruct(int a)
        {
            num = a;
        }
        
        /*
        public ~MyStruct()
        {
            
        }
        */
    }
    static class MyStaticClass
    {
        
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
        virtual public void MyVir()
        {
        }
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
