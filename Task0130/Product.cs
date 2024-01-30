using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0130
{
    internal class Product
    {
        private static int _counter = 0;
        public int No;
        public string Name;
        public double Price;
        public ProductType Type;

        public Product()
        {
            _counter++;
            No = _counter;
        }
    }
}
