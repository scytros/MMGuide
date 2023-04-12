namespace Question1.Models;

public class GenericList<T>
{
    public void DoSomething(T genericItem)
    {
        if (typeof(T) == typeof(Animal))
        {
            Console.WriteLine("Foo Animal");
        }
        else if(typeof(T) == typeof(double))
        {
            Console.WriteLine("Foo Number");
        }
    }
}