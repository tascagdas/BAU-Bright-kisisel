namespace P02_MethodOverload;

class Program
{
    /// <summary>
    /// Bu metot aldigi iki tam sayiyi toplayip sonucu tam sayi olarak dondurur.
    /// </summary>
    /// <param name="sayi1">Ilk girilecek bir tam sayi</param>
    /// <param name="sayi2">Toplanacak ikinci tam sayi deger</param>
    /// <returns>Geriye tam sayi bir deger dondurur.</returns>
    static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    static int Topla(int sayi1, int sayi2, int sayi3)
    {
        return sayi1 + sayi2 + sayi3;
    }

    static double Topla(double sayi1, double sayi2)
    {
        return sayi1 + sayi2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Topla(5,6,5));
        Console.WriteLine();
        

    }
}

