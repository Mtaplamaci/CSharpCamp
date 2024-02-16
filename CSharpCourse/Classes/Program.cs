// See https://aka.ms/new-console-template for more information

using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();   
productManager.Add();
productManager.Update();


Customer customer = new Customer
{
    Ctiy = "Ankara",
    Id = 1,
    FirstName = "Engin",
    LastName = "Demiroğ"
};

Customer customer2 = new Customer
{
    Id = 2,
    Ctiy = "İstanbul",
    FirstName = "Derin",
    LastName = "Demiroğ"
};

Console.WriteLine( customer2.FirstName );