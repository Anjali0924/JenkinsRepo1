using System;
using System.Collections.Generic;
using System.Text;

namespace prjThirdApplication
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }


        internal Person(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;

        }
    }
    class GenericEg
    {
        static void ListEg()
        {
            //typesafe
            List<string> fruits=new List<string>();
            fruits.Add("Mango");
            fruits.Add("Apple");
            fruits.Add("Orange");

            fruits.Insert(1, "Pineapple");
            fruits.RemoveAt(3);
            //fruits.Add(10); //typesafe

            List<string> vegetables = new List<string>();
            vegetables.Add("Carrot");
            vegetables.Add("Beetroot");
            vegetables.AddRange(fruits); //adding onelist to another list

            foreach(var list in fruits)
            {
                Console.WriteLine("Fruits:{0}", list);
            }

            Console.WriteLine("Vegetables");
            foreach (var list in vegetables)
            {
                Console.WriteLine("Vegetables:{0}", list);
            }

        }

        //key value pair Dictionary

        static void DictionaryEg()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "java");
            dt.Add(2, "Networks");
            dt.Add(3, "AI");

            foreach(KeyValuePair<int,string> kp in dt)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
        }

        //sortedlist
        static void SortedListEg()
        { //sorted list sorts according to the key
            SortedList<int, string> dt = new SortedList<int, string>();
            dt.Add(1, "java");
            dt.Add(3, "Networks");
            dt.Add(2, "AI");

            foreach (KeyValuePair<int, string> kp in dt)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
        }


        //Queue
       /* static void QueueEg()
        {

        }*/

        //stack
        static void StackEg()
        { //push,pop,peep,contains,clear,methods

            Stack<int> st = new Stack<int>();
            st.Push(40);
            st.Push(30);
            st.Push(10);
            st.Push(50);

            foreach(var stack in st)
            {
                Console.WriteLine(stack); //output:50,10,30,40
            }

            st.Pop();
            Console.WriteLine("After 1 POP");
            foreach (var stack in st)
            {
                Console.WriteLine(stack); //output:10,30,40
            }

            Console.WriteLine("Peek : {0}", st.Peek()); //to display first element of stack
        }




        static void Main()
        {
            ListEg();

            Console.WriteLine("Person Details");
            Console.WriteLine("--------------------");
            List<Person> person = new List<Person>();
            person.Add(new Person(1, "SAI", "Pune"));
            person.Add(new Person(2, "Ram", "Mumbai"));
            person.Add(new Person(3, "Geetha", "Pune"));

            foreach(Person p in person)
            {
                Console.WriteLine("ID:{0} || name:{1} || City:{2}", p.id, p.name, p.city);
            }

            Console.WriteLine("----------------------");
            DictionaryEg();
            Console.WriteLine("----------------------");
            SortedListEg();
            Console.WriteLine("----------------------");
            StackEg();
        }
    }
}
