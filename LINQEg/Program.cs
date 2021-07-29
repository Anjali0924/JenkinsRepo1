using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQEg

{
    /*Query Syntax
     * from<range variable> in ienumerable <T> or iquerable<T> Collection
     * standard query operators
     * select or group by operator <result formation>
     */


    class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }

        public int age { get; set; }

        internal Student(int Rollno, string Name, string City, string Gender,int age)
        {
            this.Rollno = Rollno;
            this.Name = Name;
            this.City = City;
            this.Gender = Gender;
            this.age = age;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "English", "Maths", "Physics", "Chemistry" };

            //LINQ:Query Syntax
            //Display all books
            var result = from b in books
                         select b;
            foreach (var bname in result)
            {
                Console.WriteLine(bname);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Display the bookname that contains a.");
            //display the bookname that contains a.
            //query syntax
            var r = from bookname in books
                    where bookname.Contains('a')
                    select bookname;
            foreach (var bname in r)
            {
                Console.WriteLine(bname);
            }

            //method syntax
            var m1 = books.Where(s => s.Contains('a'));

            foreach(var bbname in m1)
            {
                Console.WriteLine(bbname);
            }
            Console.WriteLine("-------------------------------------");



            int[] Marks = { 90, 87, 78, 67, 97, 80 };
            Console.WriteLine("Minimum Marks:{0}", Marks.Min());
            Console.WriteLine("Maximum Marks:{0}", Marks.Max());

            //marks between 70 to 80

            //query syntax
            var r1 = from m in Marks
                     where m > 70 && m <= 80
                     select m;
            foreach (var mark in r1)
            {
                Console.WriteLine(mark);
            }

            //Method syntax
            var m2 = Marks.Where(mark => mark > 70 && mark < 100);
            foreach (var markk in m2)
            {
                Console.WriteLine(markk);
            }

            Console.WriteLine("-------------------------------------");


            //Count Number of student getting marks in between 70 and 80
            var r2 = (from m in Marks
                      where m > 70 && m <= 80
                      select m).Count();

            Console.WriteLine("Number of student getting marks in between 70 and 80:{0}", r2);

            List<Student> stu = new List<Student>()
            {
                new Student(1001,"Anu","Chennai","Female",24),
                new Student(1001, "Ravi", "Pune", "Male",30),
                new Student(1001, "Balu", "Mumbai", "Male",22),
                new Student(1001, "Pushpa", "Chennai", "Female",25),
            };
            //display max age of student
            //method syntax
            var student = stu.Max(stu => stu.age);

            //Display name and city where city is chennai
            //Query syntax
            var stucity = from s in stu
                          where s.City.Equals("Chennai")
                          select new { s.Name, s.City };
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Display name and city where city is chennai");
            foreach (var st in stucity)
            {
                Console.WriteLine(st.Name + " " + st.City);
            }

            //order by 
            //order the student based on gender
            //query syntax
            var stugender = from s in stu
                            orderby s.Gender, s.Name
                            select s;
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Order the student info based on gender");
            foreach (var st in stugender)
            {
                Console.WriteLine(st.Name + " " + st.City + " " + st.Gender);
            }

            //Group by
            //No of males and females
            //query syntax
            var stumf = from s in stu
                        group s by s.Gender;
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Number of males and females");

            foreach (var st in stumf)
            {
                Console.WriteLine(st.Key + " " + st.Count());
            }

        }
    }
}