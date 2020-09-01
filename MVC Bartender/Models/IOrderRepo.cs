using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bartender.Models
{
    public interface IOrderRepo
    {
        IEnumerable<Drink> getDrinks();

        Drink addDrink(int id);
        Drink removeDrink(Drink drink);
    }
}
