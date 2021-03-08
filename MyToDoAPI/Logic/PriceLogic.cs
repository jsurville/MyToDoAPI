using System.Collections.Generic;
using MyToDoAPI.Models;

namespace MyToDoAPI.Logic
{
    public class PriceLogic
    {
        private static List<Price> _priceList;

        public PriceLogic()
        {
            _priceList = new List<Price>();
        }
        public List<Price> GetAll()
        {
            var priceList = PopulatePriceList();

            return priceList;
        }

        private static List<Price> PopulatePriceList()
        {
            var price1 = new Price()
            {
                Id = 1,
                Value = "Value1"
            };

            var price2 = new Price()
            {
                Id = 2,
                Value = "Value2"
            };

            _priceList.Add(price1);
            _priceList.Add(price2);

            return _priceList;
        }
    }
}