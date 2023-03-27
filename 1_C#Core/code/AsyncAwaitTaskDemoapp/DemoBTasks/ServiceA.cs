using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitTaskDemoapp
{
    public class ServiceA
    {
        public static void TaskMethodA()
        {
            Console.WriteLine("Task id: {0} is running TaskA", Task.CurrentId);
            Console.WriteLine("\t Task id: {0} Completed", Task.CurrentId);
        }
        public static void TaskMethodB(Task t)
        {
            Console.Write("Task id: {0} is running TaskB", Task.CurrentId);
            Console.WriteLine("\t After task {0} ", t.Id);
            Thread.Sleep(15000);
            Console.WriteLine("\t task id {0} Completed", Task.CurrentId);         
        }
        public static void TaskMethodC(Task t)
        {
            Console.Write("Task id: {0} is running TaskC", Task.CurrentId);
            Console.WriteLine("\t After task {0} ", t.Id);
            Thread.Sleep(1000);
            Console.WriteLine("\t taskC id {0} Completed", Task.CurrentId);
        }
        public static void TaskMethodB1(Task t)
        {
            Console.Write("Task id: {0} is running TaskB1", Task.CurrentId);
            Console.WriteLine(" After task {0} ", t.Id);
            Console.WriteLine("\t taskB1 id {0} Completed", Task.CurrentId);
        }
        
        public static void ParentMethod()
        {
            Console.WriteLine("Inside parentTask ");
            Console.WriteLine("\t ParentTask id {0}", Task.CurrentId);
            var child = new Task(ChildTask,TaskCreationOptions.AttachedToParent);
            //var child = new Task(ChildTask);
            child.Start();
            Thread.Sleep(1000);
            Console.WriteLine("parent has started child");
        }
        public static void ChildTask()
        {
            Console.WriteLine("child started");
            Thread.Sleep(10000);
            Console.WriteLine("\t child finished");
        }
        #region A
        public static String TaskWithStringResult(Object data)
        {
            return "Hello "+data.ToString();
        }

        public static Tuple<double, double> TupleTaskWithResult(object division)
        {
            Tuple<double, double> div = (Tuple<double, double>)division;
            double result = div.Item1 / div.Item2;
            double reminder = div.Item1 % div.Item2;
            Console.WriteLine("task creates a result...");
            Tuple<double, double> data = 
                Tuple.Create<double, double>(result, reminder);
            return data;
        }
        #endregion
        public static List<string> TaskWithResultA(object v1)
        {
            List<String> slist = new List<string>();
            string str = v1.ToString();
            String[] strs = str.Split(' ');
            foreach(String s1 in strs)
                slist.Add(s1);

            Console.WriteLine("task creates a result...");
            return slist;
        }

        //Cancellation
        public static int GenerateNumbers(CancellationToken ct)
        {
            int i;
            for (i = 0; i < 10000; i++)
            {
                Console.Write("Number: {0} ", i);
                Thread.Sleep(1000);
                if (ct.IsCancellationRequested)
                {
                    break;
                }
            }
            return i;
        }
        // Notify when task is cancelled
        public static void CancelNotification()
        {
            Console.WriteLine("Task Cancelled!!");
        }

    }
}
