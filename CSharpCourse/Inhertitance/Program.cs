// See https://aka.ms/new-console-template for more information


Person[] persons = new Person[3]
{
    new Customer{FirstName="Engin"},
    new Student{FirstName="Derin"},
    new Person{FirstName="Salih"}

};

foreach (var person in persons)
{
    Console.WriteLine( person.FirstName );
}


class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}


class Person2
{
    
}



class Customer:Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Departmant { get; set; }
}