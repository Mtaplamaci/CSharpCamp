


MyList<string> sehirler = new MyList<string>();

sehirler.Add("Ankara");
sehirler.Add("istanbuul");
Console.WriteLine(sehirler.Count);
sehirler.ShowList();

class MyList<T> //Generic
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
            _array = new T[0];  
    }

    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];
        for (int i = 0; i <_tempArray.Length ; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length-1] = item;
    }

    public void ShowList()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            Console.WriteLine(_array[i]);
        }
    }

    private int _count;

    public int Count
    {
        get { return _array.Length; }
      
    }

}