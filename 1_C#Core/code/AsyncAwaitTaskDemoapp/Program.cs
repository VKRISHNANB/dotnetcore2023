using System;
using System.Threading.Tasks;

namespace AsyncAwaitTaskDemoapp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Threads
            // ThreadProgramA.TestThread();
            // ThreadProgramA.TestMultiThread();
            // ThreadProgramA.TestThreadPool();
            #endregion
            #region tasks
            // TaskSandbox.RunThreads();
            // TaskSandbox.RunThreadPool();
            // TaskSandbox.RunTasks();
            // TaskTester.TestA();
            // TaskTester.ContinueTask();
            // TaskTester.ParentAndChild();
            // TaskTester.TestStringTaskResult();
            // TaskTester.TestTupleTaskResult();
            // TaskTester.TaskResultA();
            // TaskTester.CancelDemo();
            #endregion
            #region parallel
            // ParallelDemo.M1();
            // ParallelDemo.PForEach();
            // ParallelDemo.PForEachPls();
            // ParallelDemo.ParallelInvoke();
           #endregion
            #region asyncAwait
            // TestCalculator.TestA();
            TestCalculator.TestB();
            #endregion
            Console.WriteLine("---------Completed---------");
            Console.ReadKey();
        }
    }
}
