﻿// See https://aka.ms/new-console-template for more information

List<Category> categories = new List<Category> 
{ 
    new Category{CategoryId=1,CategoryName="Bilgisayar"},
    new Category{CategoryId=2,CategoryName="Telefon"}
};

List<Product> products = new List<Product>
{
    new Product{ProductId=1,CategoryId=1,ProductName="Acer Latop",QuantityPerUnit="32 gb ram",UnitPrice=10000,UnitInStock=5},
    new Product{ProductId=2,CategoryId=1,ProductName="Asus Latop",QuantityPerUnit="16 gb ram",UnitPrice=8000,UnitInStock=3},
    new Product{ProductId=3,CategoryId=1,ProductName="Hp Latop",QuantityPerUnit="8 gb ram",UnitPrice=6000,UnitInStock=2},
    new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 gb ram",UnitPrice=5000,UnitInStock=15},
    new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 gb ram",UnitPrice=8000,UnitInStock=0}
};

Console.WriteLine("Algoritmik-------------------------");
foreach (var product in products)
{
    if (product.UnitPrice > 5000 && product.UnitInStock > 3)
    {
        Console.WriteLine( product.ProductName);
    }
}


Console.WriteLine("Linq-------------------------");
var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock>3);
foreach (var product in result)
{
    Console.WriteLine(product.ProductName);
}



static List<Product> GetProducts(List<Product> products)
{
    List<Product> filteredProduct = new List<Product>(); 
    foreach (var product in products)
    {
        if (product.UnitPrice > 5000 && product.UnitInStock > 3)
        {
           filteredProduct.Add(product);
        }

    }
    return filteredProduct;
}

static List<Product> GetProductsLinq(List<Product> products)
{
    return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList(); ;
}




class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitInStock { get; set; }
}


class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}