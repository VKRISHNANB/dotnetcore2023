using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d8Exceptions
{
    class ExceptionsDemo
    {
        public static void DemoAExceptions()
        {
            Console.WriteLine("\tEnter a no for X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter a no Y");
            int y = int.Parse(Console.ReadLine());
            Calculator c1 = new Calculator();
            int z = c1.Divide(x, y);
            Console.WriteLine("Result in M3 " + z);
        }
        public static void TestDivide()
        {
            Calculator c1 = null;
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            try
            {
                Console.WriteLine("Enter a no X");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another no Y");
                v2 = int.Parse(Console.ReadLine());
                c1 = new Calculator();
                v3 = c1.Divide(v1, v2);
                Console.WriteLine("Result of {0}/{1}={2}", v1, v2, v3);
            }
            catch (Exception err)
            {
                Console.WriteLine("Error1 Type " + err.GetType().FullName);
                Console.WriteLine("Error1 Message " + err.Message);
                Console.WriteLine("Error1 SOURCE " + err.Source);
                Console.WriteLine("Error1 TargetSite " + err.TargetSite.Name);
            }
        }
        public static void TestCatchFinally()
        {
            Console.WriteLine("Before Try");
            int v1 = 0;
           // return;
            try
            {
                Console.WriteLine("Inside Try");
                Console.WriteLine("Enter a no");
                v1 = int.Parse(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.WriteLine("Inside Catch " + err.Message);
            }
             finally
            {
                Console.WriteLine("Inside  ly");
            }
            Console.WriteLine("After  ly");
        }

        public static void TestStackTrace()
        {
            ClassA a1 = null;
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            try
            {
                Console.WriteLine("Enter a no X");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another no Y");
                v2 = int.Parse(Console.ReadLine());
                a1 = new ClassA();
                v3 = a1.M1(v1, v2);
                Console.WriteLine("Result of {0}/{1}={2}", v1, v2, v3);
            }
            catch (Exception err)
            {
                Console.WriteLine("Error1 StackTrace:\n " + err.StackTrace);
                Console.WriteLine("Error1 TargetSite:\n " + err.TargetSite.Name);
            }
        }
      
        public static void NestedTryDemo()
        {
            int x = 0; int y = 0; int z = 0;
            Calculator c1 = null;
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
                    c1= new Calculator();
                    z = c1.Divide(x,y);
                }
                catch (FormatException err)
                {
                    Console.WriteLine("\tInside NestedCatch " + err.Message);
                    //throw err;//re throw
                    throw new Exception("Test msg");
                }
                 finally
                {
                    Console.WriteLine("\tInside Nested  ly");
                }
                Console.WriteLine("Inside outer Try1 After Nested  ly");
                Console.WriteLine("Result " + z);
            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine("Inside outer Catch1 " + err.Message);
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine("Inside outer Catch2 " + err.Message);
            }
            catch (FormatException err)
            {
                Console.WriteLine("Inside outer Catch3 " + err.Message);
            }
            catch (Exception err)
            {
                Console.WriteLine("Inside outer Catch4 " + err.Message);
            }
             finally
            {
                Console.WriteLine("Inside outer  ly1");
            }
            Console.WriteLine("After outer  ly1");
        }
        //nested try and throw
        public void TestMultipleNestedTry()
        {
            try // try1
            {
                try // try2
                {
                    try //try3
                    {
                        try //try4
                        {
                            throw new Exception("bla bla");
                        }
                        catch (Exception ex0)
                        {
                            throw new ApplicationException("ex0"+ex0.Message);
                        }//end of try4
                    }
                    catch (ApplicationException ex1)
                    {
                        throw new IndexOutOfRangeException("ex1"+ex1.Message);
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception("ex2"+ex2.Message);
                    }//end of try3
                }
                catch (ApplicationException ex3)
                {
                    throw new DllNotFoundException("ex3"+ex3.Message);
                }
                catch (IndexOutOfRangeException ex4)
                {
                    throw new ArgumentNullException("ex4"+ex4.Message);
                }
                catch (Exception ex5)
                {
                    throw new Exception("ex5"+ex5.Message);
                }// end of try2
            }
            catch (ApplicationException ex6)
            {
                throw new ArgumentNullException("ex6"+ex6.Message);
            }
            catch (DllNotFoundException ex7)
            {
                throw new DllNotFoundException("ex7"+ex7.Message);
            }
            catch (ArgumentNullException ex8)
            {
                throw new ArgumentNullException("ex8"+ex8.Message);
            }
            catch (Exception ex9)
            {
                throw new ArgumentNullException("ex9"+ex9.Message);
            }// end of try1
        }//ex0 => ex1 => ex4 => ex8
        public static void TestThrow()
        {
            ThrowDemoA t1 = null;
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            try
            {
                Console.WriteLine("Enter a no");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another no");
                v2 = int.Parse(Console.ReadLine());
                t1 = new ThrowDemoA();
                v3 = t1.M1(v1, v2);
                Console.WriteLine("Result of {0}/{1}={2}", v1, v2, v3);
            }
            catch (Exception err)
            {
                Console.WriteLine("\t Inside TestThrow:");
                Console.WriteLine("Error1 Type " + err.GetType().FullName);
                Console.WriteLine("Error1 Message " + err.Message);
                Console.WriteLine("Error1 TargetSite " + err.TargetSite.Name);
                Console.WriteLine("Error1 StackTrace " + err.StackTrace);
            }
        }
        //testing Custom Exception
        public static void TestDivideACustomException()
        {
            Calculator c1 = null;
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            try
            {
                Console.WriteLine("Enter a no");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another no");
                v2 = int.Parse(Console.ReadLine());
                c1 = new Calculator();
                v3 = c1.DivideA(v1, v2);
                Console.WriteLine("Result of {0}/{1}={2}", v1, v2, v3);
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
            catch (ZeroValueException err)
            {
                Console.WriteLine("Error4 Type " + err.GetType().FullName);
                Console.WriteLine("Error4 Message " + err.Message);
                Console.WriteLine("Error4 SOURCE " + err.Source);
            }
            catch (Exception err)
            {
                Console.WriteLine("Error Type " + err.GetType().FullName);
                Console.WriteLine("Error Message " + err.Message);
                Console.WriteLine("Error SOURCE " + err.Source);
            }
        }
    }
}
