using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bartender.Models
{
    public interface IDrinkRepo
    {
        IEnumerable<Drink> getDrinks();
        Drink SaveDrink(Drink drink);
        Drink DeleteDrink(int id);

        Drink getDrink(int id);
        Drink createDrink(Drink drink);
    }
}
