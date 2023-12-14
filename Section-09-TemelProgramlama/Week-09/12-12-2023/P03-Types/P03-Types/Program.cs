namespace P03_Types;

class Program
{
    static void Main(string[] args)
    {
        #region Tam sayilar
        //c#'da veri tipleri çok önemlidir. Çeşitli veri tipleri bulunmaktadır. Özellikle sayılar ve sayı olmayanlar şeklinde incelemek iyi olacaktır.
        ////Tam Sayılar
        //byte sayi1 = 255;
        //sbyte sayi2 = 15;
        //Console.WriteLine(sayi1+""+sayi2);
        //Console.Write(sayi1);
        //Console.WriteLine(sayi2);
        //Console.WriteLine(sayi1+" sayısının alabileceği minimum değer: "+byte.MinValue);
        //Console.WriteLine(sayi1 + " sayısının alabileceği maximum değer: " + byte.MaxValue);
        //Console.WriteLine(sayi1 + " sayısının bellekte kapladığı alan: " + sizeof(byte)+"byte");
        //Console.WriteLine(sayi2+"-"+sizeof(sbyte)+"byte");
        //byte sayi1 = 10;
        //ushort sayi2 = 10;
        //uint sayi3 = 10;
        //ulong sayi4 = 10;

        //sbyte sayi5 = -10;
        //short sayi6 = -10;
        //int sayi7 = -10;
        //long sayi8 = -10;



        //Console.WriteLine(int.MinValue);
        //Console.WriteLine(int.MaxValue);
        //Console.WriteLine(sizeof(int)+"byte");


        #endregion
        #region Ondalikli sayilar
        //float sayi1 = 56.6f;
        //double sayi2 = 56.4d;
        //decimal sayi3 = 76m;



        //Console.WriteLine(float.MinValue);
        //Console.WriteLine(float.MaxValue);
        //Console.WriteLine(sizeof(float)+" byte");
        //Console.WriteLine(sayi1.GetType());

        //Console.WriteLine();

        //Console.WriteLine(double.MinValue);
        //Console.WriteLine(double.MaxValue);
        //Console.WriteLine(sizeof(double) + " byte");
        //Console.WriteLine(sayi2.GetType());


        //Console.WriteLine();

        //Console.WriteLine(decimal.MinValue);
        //Console.WriteLine(decimal.MaxValue);
        //Console.WriteLine(sizeof(decimal) + " byte");
        //Console.WriteLine(sayi3.GetType());



        #endregion
        #region Metin ve Karakterler
        //char answer = 'a';
        //string name = "Ali";

        //Console.WriteLine(answer+"tipi:"+answer.GetType());
        //Console.WriteLine(name);
        #endregion
        #region Mantiksal


        //bool isActive = true;


        //Console.WriteLine(isActive);
        #endregion
        #region Tarih Saat
        DateTime birthDay = new DateTime(1995, 4, 16);
        Console.WriteLine(birthDay);
        #endregion
        Console.ReadLine();
    }
}

