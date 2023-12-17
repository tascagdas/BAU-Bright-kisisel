

using System.Collections;

namespace P01_OOP_Intro;

public class Person
{
    //Field
    private int age;
    public int Age
    {
        get
        {return age - 10;}
        set
        {age = value;}
    }
    private string name;
    public string Name
    {
        get { return name.ToUpper(); }
        set { name = value.ToLower(); }
    }

    //kullanilmayan icin bunu yazmaya gerek yok
    private bool isStatus;


    public bool IsStatus
    {
        get
        {
            if (age>=25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
public class Product
{
    public string Name { get; set; }
    public string Desciption { get; set; }
    public decimal Price { get; set; }

}
public class Program
{
    static void Main(string[] args)
    {
        ArrayList products = new ArrayList();
        string answer;
        do
        {
            Product product = new Product();
            Console.WriteLine("Product Name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Product Description: ");
            product.Desciption = Console.ReadLine();
            Console.WriteLine("Product Price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            products.Add(product);
            Console.WriteLine();
            Console.Write("Add new product? (Y/N)");
            answer = Console.ReadLine();
        } while (answer=="Y");
        foreach (Product item in products)
        {
            Console.WriteLine($"Name: {item.Name}\t\tDescription: {item.Desciption}\t\tPrice: {item.Price}");
        }












        
        //Person ece = new Person();
        //Person haydar = new Person();
        //Person ayse = new Person();


        //ece.Age = 30;
        //ece.Name="ece";
        //ayse.Age = 20;
        //ayse.Name = "AYSeNUr";
        //haydar.Age = 25;
        //haydar.Name = "Poyraz";
        //Console.WriteLine(haydar.Age);
        //Console.WriteLine(ayse.Name);

    }
}

