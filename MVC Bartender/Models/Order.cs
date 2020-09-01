using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bartender.Models
{
    public class Order
    {
        [HiddenInput]
        public int ID { get; set; }

    }
}
