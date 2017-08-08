using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBooks_Logic.model
{
    public class Order
    {
        [Key]
        public int IdShoppingCart { get; set; }
        public int IdBooks { get; set; }
        public double TotalPrice { get; set; }
        public int Count { get; set; }

    }

}
