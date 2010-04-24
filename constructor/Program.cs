using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Polymorphism
//seal,new,abstract, container
//override operator, 
//implement the method to sort and compare in List<T>
namespace constructor
{
    public class MyObject : IComparable<MyObject>
    {
        private int _myInt;

        public int MyInt
        {
            get { return _myInt; }
            set { _myInt = value; }
        }

        public MyObject(int value)
        {
            _myInt = value;
        }

        public int CompareTo(MyObject obj)
        {
            return _myInt.CompareTo(obj.MyInt);
        }
        public int MySortFunction(MyObject obj1, MyObject obj2)
        {
            return obj2.CompareTo(obj1);
        }
    }
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
    public class MyListSorter : IComparer<MyObject>
    {
        public int Compare(MyObject obj1, MyObject obj2)
        {
            return obj2.CompareTo(obj1);
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

            List<Person> young = people.FindAll
                (
                    delegate(Person p)
                    {
                        return p.age < 25;
                    }
                );
            Console.WriteLine("Age is less than 25");
            young.ForEach
                (
                    delegate(Person p)
                    {
                        Console.WriteLine(String.Format("{0} {1}", p.age, p.name));
                    }
                );

            Console.WriteLine("Sorted list, by name");
            people.Sort
                (
                    delegate(Person p1, Person p2)
                    {
                        return p1.name.CompareTo(p2.name);
                    }
                );
            people.ForEach(delegate(Person p) { Console.WriteLine(String.Format("{0} {1}", p.age, p.name)); });

            people.Sort(delegate(Person p1, Person p2) { return p1.age.CompareTo(p2.age); });
            Console.WriteLine("Sorted list, by age");
            people.ForEach(delegate(Person p) { Console.WriteLine(String.Format("{0} {1}", p.age, p.name)); });
            List<MyObject> myObjectList = new List<MyObject>();

            myObjectList.Add(new MyObject(3));
            myObjectList.Add(new MyObject(1));
            myObjectList.Add(new MyObject(4));
            myObjectList.Add(new MyObject(2));

            myObjectList.Sort();

            foreach (MyObject obj in myObjectList)
                Console.WriteLine(obj.MyInt);
            myObjectList.Sort(new MyListSorter());

            foreach (MyObject obj in myObjectList)
                Console.WriteLine(obj.MyInt);
        }
    }
}
