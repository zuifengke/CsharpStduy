using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnderstandAsyncAwait
{
    public class FruitSearchService
    {
        public Task<List<Fruit>> Search()
        {
            var task = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("starting search fruits");
                Thread.Sleep(1000);
                var fruits = new List<Fruit>()
                {
                    new Fruit(){Name = "Name1",Price = 10},
                    new Fruit(){Name = "Name2",Price = 11},
                    new Fruit(){Name = "Name3",Price = 12}
                };
                Console.WriteLine("finishing search fruits");
                return fruits;
            });

            return task;
        } 
    }

    public class Fruit
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
