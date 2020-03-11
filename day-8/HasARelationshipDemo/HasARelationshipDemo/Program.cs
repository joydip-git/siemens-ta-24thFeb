using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasARelationshipDemo
{
    class Category
    {
        int categoryId;
        string categoryName;

        //navigation attribute
        List<Product> products;

        public Category()
        {

        }
        public Category(int id, string name, List<Product> products = null)
        {
            categoryId = id;
            categoryName = name;
            this.products = products;
        }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName
        {
            get => categoryName;
            set => categoryName = value;
        }
        public List<Product> Products
        {
            get => products;
            set => products = value;
        }
    }

    class Product
    {
        int productId;
        string productName;
        decimal price;
        string description;
        int categoryId;

        //navigation attribute
        Category categoryInfo;

        public Product()
        {

        }
        public Product(int id, string name, decimal price, string description, Category category)
        {
            productId = id;
            productName = name;
            this.price = price;
            this.description = description;
            this.categoryInfo = category;
            if (category != null)
                this.categoryId = category.CategoryId;
        }
        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public int CategoryId
        {
            get => categoryId;
            protected set => categoryId = value;
        }

        //navigation property
        public Category CategoryInfo { get => categoryInfo; set => categoryInfo = value; }
    }
    class Program
    {
        static List<Category> CreateCategoryList()
        {
            Category bookCategory = new Category(1, "Book");
            Category laptopCategory = new Category(2, "Laptop");
            Category mobileCategory = new Category(3, "Mobile");

            List<Category> categoryTable = new List<Category>();
            categoryTable.Add(bookCategory);
            categoryTable.Add(laptopCategory);
            categoryTable.Add(mobileCategory);

            return categoryTable;
        }
        static List<Product> CreateProductList(List<Category> categoryTable)
        {
            Product dellLaptop = new Product(1, "dell xps", 34000, "new laptop from dell", categoryTable[1]);
            Product hpLaptop = new Product(2, "hp probook", 43000, "new laptop from hp", categoryTable[1]);
            Product oppoMobile = new Product(3, "oppo f10", 23000, "new mobile from oppo", categoryTable[2]);
            Product alchemistBook = new Product(4, "the alchemist", 340, "new book", categoryTable[0]);

            //C#3.0(2007)-collection initialzer
            List<Product> productTable = new List<Product>
            {
                dellLaptop,
                hpLaptop,
                oppoMobile,
                alchemistBook
            };
            categoryTable[0].Products = new List<Product> { productTable[3] };
            categoryTable[1].Products = new List<Product> {
                productTable[0], productTable[1] };
            categoryTable[2].Products = new List<Product> { productTable[2] };
            return productTable;
        }
        static void Main()
        {

            List<Category> categoryTable = CreateCategoryList();
            List<Product> productTable = CreateProductList(categoryTable);

            foreach (Category c in categoryTable)
            {
                Console.WriteLine(c.CategoryName);
                Console.WriteLine("----------------------");
                //foreach (Product p in productTable)
                //{
                //    if (p.CategoryId == c.CategoryId)
                //    {
                //        Console.WriteLine(p.ProductName);
                //    }
                //}
                List<Product> list = c.Products;
                foreach (Product p in list)
                {
                    Console.WriteLine(p.ProductName);
                }
                Console.WriteLine();
            }
            //Console.WriteLine(dellLaptop.CategoryInfo.CategoryName);

            //foreach (Category c in categoryTable)
            //{
            //    if(c.CategoryId == dellLaptop.CategoryId)
            //    {
            //        Console.WriteLine(c.CategoryName);
            //        break;
            //    }
            //}
        }
    }
}
