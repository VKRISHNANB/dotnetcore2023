using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitTaskDemoapp
{
    public static class TaskTester
    {
        public static void TestA()
        {
            // TaskFactory tf = new TaskFactory();
            // Task t1 = tf.StartNew(ServiceA.TaskMethodA);

            // Task t2 = Task.Factory.StartNew(ServiceA.TaskMethodA);
            
            Task t3 = new Task(ServiceA.TaskMethodA);
            t3.Start();
            
            Thread.Sleep(2000);
            // Can not start a task that is completed
            // t3.Start(); 
            t3= new Task(ServiceA.TaskMethodA);
            t3.Start();
        }
        

        public static void ContinueTask()
        {
            Task t1 = new Task(ServiceA.TaskMethodA);
            Task t2 = t1.ContinueWith(ServiceA.TaskMethodB);
            Task t3 = t1.ContinueWith(ServiceA.TaskMethodC);
            Task t4 = t2.ContinueWith(ServiceA.TaskMethodB1);
            t1.Start();
            Console.WriteLine("Bye from CT");
        }

        public static void ParentAndChild()
        {
            var parent = new Task(ServiceA.ParentMethod);
            Console.WriteLine("ParentStatus1: " + parent.Status);
            parent.Start();
            Console.WriteLine("ParentStatus2: " + parent.Status);
            #region A
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            #endregion
            Console.WriteLine("Parent Completed");   
        }

        // Task With Result
        // Task<T>(m1,State); 
        // T - is the result
        // m1 - Delegate to be run by task
        // State - Parameter to m1(State)
        public static void TestStringTaskResult()
        {
            String str = "To day is a Sunny Day";
            var t1 = new Task<String>
            (ServiceA.TaskWithStringResult, str);
            t1.Start();
            String result = t1.Result;
            Console.WriteLine("Result: " + result);
        }

        public static void TestTupleTaskResult()
        {
            Tuple<double, double> value = Tuple.Create<double, double>(19, 3);
            var t1 = new Task<Tuple<double, double>>(
                ServiceA.TupleTaskWithResult, value);
            t1.Start();
            Tuple<double, double> result = t1.Result;
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Quotient: {0} Reminder: {1}",
                                                    result.Item1, result.Item2);
            // t1.Wait();
            // Console.WriteLine("Quotient: {0} Reminder: {1}",
            //                                  t1.Result.Item1,t1.Result.Item2);
        }
        public static void TaskResultA()
        {
            

            var t1 = new Task<List<string>>(ServiceA.TaskWithResultA,
                            "Hello Today Is Saturday");
            t1.Start();
            String str = String.Empty;
            for (int i = 0; i < t1.Result.Count; i++)
            {
                str = "Item" + i + ": " + t1.Result[i];
                Console.WriteLine(str);
            }
        }
        //Cancellation Token
        public static void CancelDemo()
        {
            Console.WriteLine("Press 1 to cancel task");
            var cTokenSource = new CancellationTokenSource();
            var cToken = cTokenSource.Token;
            // Callback to be notified when the task is cancelled
            Action a1 = () => ServiceA.CancelNotification();
            cToken.Register(a1);

            Func<int> f1 = () => ServiceA.GenerateNumbers(cToken);
            Task<int> t2 = new Task<int>(f1, cToken);
            t2.Start();
            if (Console.ReadKey().KeyChar == '1')
            {
                cTokenSource.Cancel();
            }
            int result = t2.Result;
            Console.WriteLine("Result: " + result);
        }
    }
}
