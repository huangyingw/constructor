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
    abstract class D : B
    {
    }
    public class Person
    {
        public int age;
        public string name;

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person(50, "Fred"));
            people.Add(new Person(30, "John"));
            people.Add(new Person(26, "Andrew"));
            people.Add(new Person(24, "Xavier"));
            people.Add(new Person(5, "Mark"));
            people.Add(new Person(6, "Cameron"));
            Console.WriteLine("Unsorted list");
            people.ForEach
                (
                    delegate(Person p)
                    {
                        Console.WriteLine(String.Format("{0} {1}", p.age, p.name)); 
                    }
                );

            List<Person> young = people.FindAll(delegate(Person p) { return p.age < 25; });
            Console.WriteLine("Age is less than 25");
            young.ForEach(delegate(Person p) { Console.WriteLine(String.Format("{0} {1}", p.age, p.name)); });

            Console.WriteLine("Sorted list, by name");
            people.Sort(delegate(Person p1, Person p2) { return p1.name.CompareTo(p2.name); });
            people.ForEach(delegate(Person p) { Console.WriteLine(String.Format("{0} {1}", p.age, p.name)); });

            people.Sort(delegate(Person p1, Person p2) { return p1.age.CompareTo(p2.age); });
            Console.WriteLine("Sorted list, by age");
            people.ForEach(delegate(Person p) { Console.WriteLine(String.Format("{0} {1}", p.age, p.name)); });


        }
    }
}
