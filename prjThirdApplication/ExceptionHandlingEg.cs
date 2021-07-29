using System;
using System.Collections.Generic;
using System.Text;

namespace prjThirdApplication
{
    // Custom or user defined exception
    public class AgeNotValid : ApplicationException
    {
        public AgeNotValid(string Message) : base(Message)
        {

        }
    }
    class ExceptionHandlingEg
    {
        static void Main()
        {
            try
            {
                /*int num = 10, div = 0;
                if (div == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    num = num / div;
                }
                Console.WriteLine(num);

                int[] arr = new int[] { 10, 20, 30 };
                //Console.WriteLine(arr[6]);*/

                Console.WriteLine("Enter the age");
                int Age = Convert.ToInt32(Console.ReadLine());
                if (Age < 18)
                {
                    throw new AgeNotValid("To vote age should be greater than 18");
                }
                else
                {
                    Console.WriteLine("Eligible to vote");
                }
            }

            // Error ------> child then parent
            //catch(Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            catch (DivideByZeroException e)
            {
                //Console.WriteLine(e);
                //Console.WriteLine(e.Message);
                //Console.WriteLine(e.Source);
                Console.WriteLine("Please enter a valid number");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Hope you are good !!");
            }
        }
    }
}    