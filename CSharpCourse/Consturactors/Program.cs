// See https://aka.ms/new-console-template for more information



Customer customer1=new Customer {Id=1,FirstName="Muhammed",LastName="Taplamacı",Ctiy="İstanbul"};
Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");
Console.WriteLine( customer2.FirstName );








class Customer
{
    public Customer()
    {
        
    }
    public Customer(int id,string firstName,string lastName,string ctiy)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Ctiy = ctiy;
          
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Ctiy { get; set; }
}