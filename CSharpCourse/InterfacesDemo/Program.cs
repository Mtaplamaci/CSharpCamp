// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(),
    new Robot()
};

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2]
{
    new Worker(),
    new Manager()

};

foreach (var eat in eats)
{
    eat.Eat();
}


interface IWorker
{
    void Work();
  
}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}


public class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

public class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

public class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}