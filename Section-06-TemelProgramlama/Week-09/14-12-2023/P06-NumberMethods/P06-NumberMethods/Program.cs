namespace P06_NumberMethods;

class Program
{
    static void Main(string[] args)
    {
        //int number1 = 40;
        //int number2 = 60;
        //Console.WriteLine($"En küçük:{Math.Min(number1,number2)}");
        //Console.WriteLine($"En büyük:{Math.Max(number1, number2)}");
        //int sayi = 4;
        //int us = 2;
        //int result = Convert.ToInt32(Math.Pow(sayi, us));
        //Console.WriteLine(result);

        //Console.Write("Kuvvetini almak istediğiniz sayıyı giriniz:");
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Üssü giriniz:");
        //int number2 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine(Math.Pow(number1,number2));

        double sayi = 5.493486;
        Console.WriteLine(sayi);
        Console.WriteLine($"Ceiling: {Math.Ceiling(sayi)}");
        Console.WriteLine($"Floor: {Math.Floor(sayi)}");
        Console.WriteLine($"Round: {Math.Round(sayi)}");
        Console.WriteLine($"Round2: {Math.Round(sayi,2)}");



        Console.ReadLine();
    }
}