using System;
using System.Collections.Generic;
using System.Text;

namespace prjThirdApplication
{
    //Generic  Class
    //in generic class we can have both non generic and generic methods
    //but accessing non generic method through generic class is not possible
    class Sample<T>
    {
        T Name;
        T City;
        
        internal Sample(T Name,T City)
        {
            this.Name = Name;
            this.City = City;
        }


        //normal method
        internal void Add(int x,int y)
        {
            Console.WriteLine("Addition is :{0}", (x + y));
        }

        //Generic Method
        //<T> is being used which can be of any datatype we want to assign to
        
        internal void Swap<T>(T x,T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("X is :{0} || Y is :{1}", x, y);
        }
    }

    /*
    Generic Constraint
    where T:struct //value type
    where T:class //reference type
    where T:new //default parameter constraint
    where T:<interface name>

    */

    class Student<T> where T : struct
    {

    }
    class GenericClass_Methods
    {
        static void Main()
        {
            Sample<string> sample = new Sample<string>("Anu", "Chennai");
            sample.Swap<int>(6, 8);
            sample.Swap<string>("Good", "Morning");

            //struct constraint
            // Student<string> student=new Student<string>();


            Student<int> student = new Student<int>();
               
        }
    }
}





