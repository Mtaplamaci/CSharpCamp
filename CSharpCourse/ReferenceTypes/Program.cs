// See https://aka.ms/new-console-template for more information


int sayi1 = 10;
int sayi2 = 20;

sayi1 = sayi2;
sayi2 = 100;
Console.WriteLine("sayi1: "+sayi1 );


int[] sayilar1 =new int[] { 1, 2, 3 };
int[] sayilar2 =new int[] { 10, 20, 30 };
sayilar1 = sayilar2;
sayilar2[0]=1000;
Console.WriteLine("sayilar1[0]: " + sayilar1[0]);


List<int> list1 = new List<int>() {1,2,3,};
List<int> list2 = new List<int>() { 10, 20, 30 };
list1=list2;
list2[0]=1000;

Console.WriteLine("list1: "+list1[0]);


Person person1 = new Person();
Person person2 = new Person();


person1.FirstName = "Engin";
person2 = person1;
person1.FirstName = "Derin";

Console.WriteLine("person2 firsName: "+person2.FirstName);


Customer customer = new Customer();
customer.FirstName = "Salih";
customer.CreditCardtNumber = "1213";
Employee employe = new Employee();
employe.FirstName = "Veli";

Person person3 = customer;
Console.WriteLine("person3 FirstName: "+ person3.FirstName);
customer.FirstName = "Aydın";
Console.WriteLine("person3 FirstName: " + person3.FirstName);
Console.WriteLine("customer vreditcardnumber: " + customer.CreditCardtNumber);

Console.WriteLine(  ((Customer)person3).CreditCardtNumber="65465465456");

Console.WriteLine("customer vreditcardnumber: " + customer.CreditCardtNumber);

PersonManager personmanager = new PersonManager();
personmanager.Add(employe);
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer: Person
{
    public string CreditCardtNumber { get; set; }
}

class Employee:Person
{
    public int EmployeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}