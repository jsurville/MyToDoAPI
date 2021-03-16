using System.Collections.Generic;
using MyToDoApp.DAL;
using System.Linq;
using MyToApp.Models;

namespace MyToDoAPI.Logic
{
    public class PriceLogic
    {
        private static IEnumerable<Price> _priceList = new List<Price>();
        private MyToDoContext db = new MyToDoContext();

        public IEnumerable<Price> GetAll()
        {
            
            _priceList = db.Prices.ToList();

            return _priceList;
        }        
    }
}