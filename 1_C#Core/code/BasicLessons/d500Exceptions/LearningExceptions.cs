using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d8Exceptions
{
    class LearningExceptions
    {
        public static void TestDivide()
        {
            Calculator c1 = null;// new d8.Calculator();
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            try
            {
                Console.WriteLine("Enter a no");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another no");
                v2 = int.Parse(Console.ReadLine());
                v3 = c1.Divide(v1, v2);
                Console.WriteLine("Result of {0}/{1}={2}", v1, v2, v3);
            }
            catch (Exception err)
            {
                Console.WriteLine("Error1 Type " + err.GetType().FullName);
                Console.WriteLine("Error1 Message " + err.Message);
                Console.WriteLine("Error1 SOURCE " + err.Source);
            }
        }

        public static  void TestDivideA()
        {
            Calculator c1 = null;// new d8.Calculator();
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            try { 
                Console.WriteLine("Enter a no");
                v1 =int.Parse( Console.ReadLine());
                Console.WriteLine("Enter another no");
                v2 = int.Parse( Console.ReadLine());
                v3 = c1.Divide(v1, v2);
                Console.WriteLine("Result of {0}/{1}={2}",v1,v2,v3);
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine("Error1 Type " + err.GetType().FullName);
                Console.WriteLine("Error1 Message " + err.Message);
                Console.WriteLine("Error1 SOURCE " + err.Source);
            }
            catch (ArithmeticException err)
            {
                Console.WriteLine("Error2 Type " + err.GetType().FullName);
                Console.WriteLine("Error2 Message " + err.Message);
                Console.WriteLine("Error2 SOURCE " + err.Source);
            }
            catch (FormatException err)
            {
                Console.WriteLine("Error3 Type " + err.GetType().FullName);
                Console.WriteLine("Error3 Message " + err.Message);
                Console.WriteLine("Error3 SOURCE " + err.Source);
            }
            catch (Exception err)
            {
                Console.WriteLine("Error Type "+err.GetType().FullName);
                Console.WriteLine("Error Message "+err.Message);
                Console.WriteLine("Error SOURCE "+err.Source);
            }
        }

        public static void M1()
        {
            Console.WriteLine("Before Try");
            int v1 = 0;            
            try
            {
                Console.WriteLine("Enter a no");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Inside Try");              
            }
            catch(Exception err)
            {
                Console.WriteLine("Inside Catch "+err.Message);
            }
            finally
            {
                Console.WriteLine("Inside finally");
            }
            Console.WriteLine("After finally");
        }

        public static void M2()
        {
            int x = 0; int y = 0; int z = 0;
            Console.WriteLine("Before Try1");
            try
            {
                Console.WriteLine("Inside Try1");
                try
                {
                    Console.WriteLine("\tInside Nested Try");
                    Console.WriteLine("\tEnter a no");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("\tEnter a no");
                    y = int.Parse(Console.ReadLine());
                    Calculator c1 = new Calculator();
                    z = c1.DivideA(x,y);
                }
                catch (FormatException err)
                {
                    Console.WriteLine("\tInside NestedCatch " + err.Message);
                     throw err;//re throw
                    //throw new Exception("Test msg");
                }
                finally
                {
                    Console.WriteLine("\tInside Nested Finally");
                }
                Console.WriteLine("Inside outer Try1 After Nested Finally");
                Console.WriteLine("Result " + z);
            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine("Inside outer Catch1 " + err.Message);
            }
            catch (Exception err)
            {
                Console.WriteLine("Inside outer Catch1 M2 " + err.Message);
                throw err;
            }
            finally
            {
                Console.WriteLine("Inside outer Finally1");
            }
            Console.WriteLine("After outer Finally1");
        }
        public static void M3()
        {
            Console.WriteLine("\tEnter a no");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter a no");
            int y = int.Parse(Console.ReadLine());
            Calculator c1 = new Calculator();
            int z = c1.DivideA(x, y);
            Console.WriteLine("Result in M3 "+z);
        }
    }
}
