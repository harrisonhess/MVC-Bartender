using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bartender.Models
{
    public class DrinkRepo : IDrinkRepo
    {
        private List<Drink> DrinkList;

        public DrinkRepo()
        {
            DrinkList = new List<Drink>()
            {
                new Drink {ID = 1, DrinkName = "Rum & Coke", DrinkDesc = "Classic mixture of rum and Coca-Cola", DrinkPrice = 5.99},
                new Drink {ID = 2, DrinkName = "Mojito", DrinkDesc = "Classic mixture of white rum, lime, sugar, and soda", DrinkPrice = 6.99},
                new Drink {ID = 3, DrinkName = "Bloody Mary", DrinkDesc = "Classic mixture of tomato juice, vodka, and spices", DrinkPrice = 7.99}
            };
        }
        public Drink createDrink(Drink drink)
        {
            if (DrinkList.Count != 0)
            {
                drink.ID = DrinkList.Max(v => v.ID) + 1;
            }
            else
            {
                drink.ID = 1;
            }
            DrinkList.Add(drink);
            return drink;
        }

        public Drink DeleteDrink(int id)
        {
            DrinkList.Remove(DrinkList.FirstOrDefault(v => v.ID == id));
            return null;
        }

        public Drink getDrink(int id)
        {
            return DrinkList.FirstOrDefault(v => v.ID == id);
        }

        public IEnumerable<Drink> getDrinks()
        {
            return DrinkList;
        }

        public Drink SaveDrink(Drink drink)
        {
            Drink temp = DrinkList.FirstOrDefault(v => v.ID == drink.ID);
            if (temp != null)
            {
                temp.DrinkName = drink.DrinkName;
                temp.DrinkDesc = drink.DrinkDesc;
                temp.DrinkPrice = drink.DrinkPrice;
            }
            return temp;
        }
    }
}
