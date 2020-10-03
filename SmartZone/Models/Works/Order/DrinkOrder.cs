using SmartZone.Models.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartZone.Models.Works.Order
{
    public class DrinkOrder
    {
        public int DrinkOrderId { get; set; }
        public DateTime OrderTime { get; set; }
        public DrinkDTO Drinks { get; set; }
        public decimal DrinkPrice { get; set; }
    }
}
