using System;
using Business;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BusinessTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
       // [TestMethod]
        public void When_FindAllProductsIsCaleed_Then_ReturnAllProducts()
        {
            ProductRepository ProductRepositoryInstance = CreateSUT();
            List<Product> ExpectedOutput = new List<Product>();
            ExpectedOutput.Add(new Product("Apples", "Red", DateTime.Now, 100, 20));
            ExpectedOutput.Add(new Product("Oranges", "Sweet", DateTime.Now, 100, 20));
            ExpectedOutput.Add(new Product("Pears", "From grandma's garden", DateTime.Now, 100, 20));
            ExpectedOutput.Should().BeEquivalentTo(ProductRepositoryInstance.FindAllProducts());
        }

        private ProductRepository CreateSUT()
        {
            return new ProductRepository(new Product("Apples", "Red", DateTime.Now, 100, 20),
                                         new Product("Oranges", "Sweet", DateTime.Now, 100, 20),
                                         new Product("Pears", "From grandma's garden", DateTime.Now, 100, 20));
        }
    }
}
