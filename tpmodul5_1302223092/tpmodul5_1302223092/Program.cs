public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }

}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> dataString = new DataGeneric<string>("1234567890");
        dataString.PrintData();

        DataGeneric<int> dataInt = new DataGeneric<int>(123456789);
        dataInt.PrintData();
    }
}