using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bartender.Models
{
    public class OrderRepo : IOrderRepo
    {
        private List<Drink> order;

        public OrderRepo()
        {
            order = new List<Drink> { };
        }

        public Drink addDrink(int id)
        {
            Drink temp = getDrinks().FirstOrDefault(v => v.ID == id);
            order.Add(temp);
            return null;
        }

        public IEnumerable<Drink> getDrinks()
        {
            return order;
        }

        public Drink removeDrink(Drink drink)
        {
            order.Remove(drink);
            return drink;
        }
    }
}
