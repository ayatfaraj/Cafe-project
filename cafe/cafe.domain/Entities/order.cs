using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.domain.Entities
{
    internal class Order
    {
        public int Num { get; set; }
        public float Total { get; set; }
        public required string Orderaddress { get; set; }
        public int DateOfOrder { get; set; }
        public required List<User> Useres { get; set; }

    }

}