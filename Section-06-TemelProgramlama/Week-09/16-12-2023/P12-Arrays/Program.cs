using System.Collections;

namespace P12_Arrays;

class Program
{
    static void Main(string[] args)
    {
        //int[] numbers = new int[3];
        //int[] ages = new int[3] { 5, 3, 15 };
        //int[] sizes = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //Console.WriteLine(sizes[0]);


        //int[] numbers = new int[50];
        //Random random = new Random();
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    numbers[i] = random.Next(1,101);

        //}

        //ArrayList ciftsayilar = new ArrayList();
        //ArrayList teksayilar = new ArrayList();
        //foreach (var item in numbers)
        //{
        //    if (item%2==0)
        //    {
        //        ciftsayilar.Add(item);
        //    }
        //    else
        //    {
        //        teksayilar.Add(item);
        //    }
        //}
        //Console.WriteLine($"Cift sayi adedi: {ciftsayilar.Count}");
        //Console.WriteLine($"Tek sayi adedi: {teksayilar.Count}");





        Random random = new Random();
        int[] teksayilar = new int[5];
        int[] ciftsayilar = new int[5];
        for (int i = 0; i < 5; i++)
        {
            int sayi = 0;
            do
            {
                sayi = random.Next(1, 101);

            } while (sayi % 2 != 1);
            teksayilar[i] = sayi;

            do
            {
                sayi = random.Next(1, 101);

            } while (sayi % 2 != 0);
            ciftsayilar[i] = sayi;
        }
        Console.WriteLine("Tek sayilar");
        foreach (var item in teksayilar)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("cift sayilar");
        foreach (var item in ciftsayilar)
        {
            Console.WriteLine(item);
        }
    }
}

