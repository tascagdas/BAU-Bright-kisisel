using P06_Static.Helper;
namespace P06_Static;
public static class Deneme
{
    public static int Sayi { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        string name = "Cagdas?Tas";
        //HelperMethods helper = new HelperMethods();
        //Console.WriteLine(helper.EditText(name));
        Console.WriteLine(HelperMethods.EditText(name));

    }
}

