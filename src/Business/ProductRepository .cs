using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business
{
    public class ProductRepository
    {
        public ProductRepository(params Product[] InitialProducts)
        {
            if (InitialProducts == null)
            {
                throw new ArgumentNullException();
            }
            else if (InitialProducts.Length > 2)
            {
                Products = new List<Product>();
                foreach (var item in InitialProducts)
                {
                    Products.Add(item);
                }
            }
            else
            {
                throw new Exception("Not enogth products");
            }
        }

        public List<Product> Products { get; private set; }

        public Product GetPoductByName(string ProductName)
        {
            if (ProductName == null)
            {
                throw new ArgumentNullException();
            }
            foreach (var ProductInstance in Products)
            {
                if (ProductInstance.Name == ProductName)
                {
                    return ProductInstance;
                }
            }
            return null;
        }

        public List<Product> FindAllProducts()
        {
            return Products;
        }

        public void AddProduct(Product ProductInstance)
        {
            if (ProductInstance == null)
            {
                throw new ArgumentNullException();
            }
            Products.Add(ProductInstance);
        }

        public Product GetProductByPosition(int position)
        {
            if (position < 0 || position >= Products.Count())
            {
                throw new IndexOutOfRangeException();
            }
            return Products.ElementAt(position);
        }

        public void RemoveProductByName(string ProductName)
        {
            if (ProductName == null)
            {
                throw new ArgumentNullException();
            }
            Product ProductToBeRemoved = GetPoductByName(ProductName);
            Products.Remove(ProductToBeRemoved);
        }
    }
}
