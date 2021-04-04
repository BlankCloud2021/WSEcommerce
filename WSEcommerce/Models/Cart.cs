using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEcommerce.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem(Products product, int quantity)
        {
            CartLine line = Lines.Where(p => p.Product.Product_Id == product.Product_Id).FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(Products product) =>
            Lines.RemoveAll(l => l.Product.Product_Id == product.Product_Id);
        public decimal ComputeTotalValue() =>
              Lines.Sum(e => e.Product.Price * e.Quantity);
        public void Clear() => Lines.Clear();

    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Products Product { get; set; }
        public int Quantity { get; set; }
    }
}

