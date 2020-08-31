using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace MVC_Bartender.Models
{
    public class Drink
    {
        [HiddenInput]
        public int ID { get; set; }

        [Display(Name = "Drink Name")]
        [Required(ErrorMessage = "Please enter drink name")]
        public string DrinkName { get; set; }

        [Display(Name ="Drink Description")]
        [Required(ErrorMessage = "Please enter drink description")]
        public string DrinkDesc { get; set; }

        [Display(Name = "Drink Price")]
        [Required(ErrorMessage = "Please enter drink price")]
        public double DrinkPrice { get; set; }

    }
}
