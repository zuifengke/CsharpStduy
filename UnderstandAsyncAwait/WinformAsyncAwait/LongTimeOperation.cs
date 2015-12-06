using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinformAsyncAwait
{
    class LongTimeOperationA
    {
        public Task<string> GetValue()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "ResultA";
            });
        } 
    }

    class LongTimeOperationB
    {
        public Task<string> GetValue()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "ResultB";
            });
        }
    }
}
