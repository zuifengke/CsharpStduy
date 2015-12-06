using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandAsyncAwait
{
    public class SearchService
    {
        public async Task ShowSearchResultA()
        {
            var foodsSearch = new FoodSearchService().Search();
            var fruitsSearch = new FruitSearchService().Search();

            var foods = await foodsSearch;

            foods.ForEach(f => Console.WriteLine("food:{0}", f.Name));

            Console.WriteLine("done");
        }

        public void ShowSearchResultB()
        {
            var foodsSearch = new FoodSearchService().Search();
            var fruitsSearch = new FruitSearchService().Search();

            var foods = foodsSearch.Result;

            foods.ForEach(f => Console.WriteLine("food:{0}", f.Name));

            Console.WriteLine("done");
        }

        public void ShowSearchResultC()
        {
            var foodsSearch = new FoodSearchService().Search();
            var fruitsSearch = new FruitSearchService().Search();

            var callback = foodsSearch as ICallBackRegister;
            callback.Register<List<Food>>(foods =>
            {
                foods.ForEach(f => Console.WriteLine("food:{0}", f.Name));
                Console.WriteLine("done");
            }).Await(foodsSearch);

        }

    }
}
