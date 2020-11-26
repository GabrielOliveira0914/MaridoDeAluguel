using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Model
{
    public class Produto
    {
        public int Sku { get; set; }
        public string Name { get; set; }
        public Inventory Inventory { get; set; }
    }
}
