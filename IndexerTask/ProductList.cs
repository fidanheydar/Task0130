using IndexerTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0130
{
    internal class ProductList
    {
        private Product[] _products;
        public ProductList(int size)
        {
            _products = new Product[size];
        }

        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < _products.Length)
                {
                    return _products[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
            set
            {
                if (index >= 0 && index < _products.Length)
                {
                    if (_products[index] == null)
                    {
                        _products[index] = value;
                    }
                    else
                    {
                        throw new InvalidOperationException($"Product with index {index} already exists.");
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
        }
    }
}
