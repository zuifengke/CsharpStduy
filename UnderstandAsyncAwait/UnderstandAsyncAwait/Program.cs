using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => new SearchService().ShowSearchResultA()).Wait();

            //new SearchService().ShowSearchResultB();

            Console.ReadLine();
        }
    }
}
