using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.domain.Entities
{
    public class User
    {
        public int Pass { get; set; }
        public required string Name { get; set; }
        public int Id { get; set; }
        public required List<Order> Orders { get; set; }
    }
}
