namespace P04_ReferenceTypes;

class Product
{

};
class Program
{
    static void Main(string[] args)
    {
        int number1=50;

        Random random = new Random();
        int sayi1 = random.Next();

        Product urun1 = new Product();

        Console.WriteLine(sayi1);
        Console.ReadLine();
    }
}

