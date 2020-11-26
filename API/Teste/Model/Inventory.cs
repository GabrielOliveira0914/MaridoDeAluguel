using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Model
{
    public class Inventory
    {
        public int Quantity { get; set; }

        public Warehouses Warehouses { get; set; }
    }
}
