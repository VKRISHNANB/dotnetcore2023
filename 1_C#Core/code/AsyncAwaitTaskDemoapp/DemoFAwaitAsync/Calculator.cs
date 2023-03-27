using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitTaskDemoapp
{
    public class Calculator
    {
        public int Add(params int[] data)
        {
            int result=0;
            foreach (var item in data)
            {
                result+=item;
                Thread.SpinWait(800000000);
            }
            return result;
        }
        public Task<int> AddAsync(params int[] data)
        {           
            return Task.Factory.StartNew(()=>Add(data));
        }
    }
}