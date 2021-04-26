using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEcommerce.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Products product, int quantity)
        {
            CartLine line = Lines.Where(p => p.Products.Product_Id == product.Product_Id).FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Products = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(Products product) =>
            Lines.RemoveAll(l => l.Products.Product_Id == product.Product_Id);
        public decimal ComputeTotalValue() =>
              Lines.Sum(e => e.Products.Price * e.Quantity);
        public virtual void Clear() => Lines.Clear();

    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Products Products { get; set; }
        public int Quantity { get; set; }
    }
}

