using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnderstandAsyncAwait
{
    public class FoodSearchService
    {
        public Task<List<Food>> Search()
        {
            var task = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("starting search foods");
                Thread.Sleep(1000);
                var foods=new List<Food>()
                {
                    new Food(){Name = "Name1",Price = 10},
                    new Food(){Name = "Name2",Price = 11},
                    new Food(){Name = "Name3",Price = 12}
                };
                Console.WriteLine("finishing search foods");
                return foods;
            });

            return task;
        } 
    }

    public class Food
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
