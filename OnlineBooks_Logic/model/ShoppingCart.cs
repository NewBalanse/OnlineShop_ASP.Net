using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBooks_Logic.model
{
    public class ShoppingCart
    {
        [Key]
        public int ID { get; set; }
        public int IdUser { get; set; }

    }



}
