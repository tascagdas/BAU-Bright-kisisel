namespace P13_Mothods;

class Program
{
    static void SelamVer()
    {
        Console.WriteLine("Gunaydin!");
    }
    static int KacKelime(string metin)
    {
        string[] kelimeler = metin.Split(" ");

        return kelimeler.Length;
    }
    static int KelimeAdedi(string metin, string aranicak, bool buyukKucuk)
    {
        if (!buyukKucuk)
        {
            metin = metin.ToLower();
            aranicak = aranicak.ToLower();
        }

        string[] kelimeler = metin.Split(' ');
        int adet = 0;
        foreach (string kelime in kelimeler)
        {
            if (kelime==aranicak)
            {
                adet++;
            }
        }
        return adet;
    }
    static int[] SayiUret(int adet, int min, int max)
    {
        Random random = new Random();
        int[] sayilar = new int[adet];
        for (int i = 0; i < adet; i++)
        {
            sayilar[i] = random.Next(min, max);
        }
        return sayilar;
    }
    static int SesliHarfAdedi(string metin)
    {
        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'ü', 'u', 'ö', 'o' };
        int sesliHarfCounter = 0;
        metin = metin.ToLower();
        for (int i = 0; i < metin.Length; i++)
        {
            if (sesliHarfler.Contains(metin[i]))
            {
                sesliHarfCounter++;
            }
        }
        return sesliHarfCounter;
    }
    static int [] SesliSessizHarfAdedi(string metin)
    {
        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'ü', 'u', 'ö', 'o' };
        char[] sessizHarfler = { 'b', 'c', 'd', 'f', 'g', 'h', 'y', 'z','m','n','p','r' };
        int sesliHarfCounter = 0;
        int sessizHarfCounter = 0;
        for (int i = 0; i < metin.Length; i++)
        {
            if (sesliHarfler.Contains(metin[i]))
            {
                sesliHarfCounter++;
            }
            else if (sessizHarfler.Contains(metin[i]))
            {
                sessizHarfCounter++;
            }
        }
        int[] sesliSessizHarfAdetleri = { sesliHarfCounter, sessizHarfCounter };
        return sesliSessizHarfAdetleri;

    }
    // icinde turkce karakter barindirmadan tum kucuk harfleri 0-9 arasindaki rakamlari nokta isaretlerini barindirabilen toplam uzunlugu 6 karakter olacak sekilde random bir sifre ureten metod yaziniz.

    static string RandomPassword()
    {
        string karakterler = "qwertyuiopasdfghjklzxcvbnm1234567890.,+-";
        Random random = new Random();
        string password = "";
        for (int i = 0; i < 6; i++)
        {
            password += karakterler[random.Next(0, karakterler.Length)];
        }
        return password;
    }

    // Tekrar sifre uretme
    // 1) sifre mutlaka harfle baslamali.
    // 2) sifre icinde bir rakam olmali.
    // 3) sifre icinde bir adet ozel karakter olmali
    // 4) kalan karakterler harf olmali
    // 5) toplam uzunlugu 6 karakter olmali
    // 6) buyuk harf yok

    static string RandomPasswordNext()
    {
        string ozelKarakterler = ".,+-";
        string harfler = "qwertyuiopasdfghjklzxcvbnm";
        string rakamlar = "1234567890";
        Random random = new Random();
        string password = "";
        password += harfler[random.Next(0, harfler.Length)];
        for (int i = 1; i < 6; i++)
        {
            // EKSIKKKKK ===========
        }


    }
    static void Main(string[] args)
    {

        //Console.WriteLine(RandomPassword());






        //Console.WriteLine(SesliHarfAdedi("Melek yagci ve aysenur gezgin"));

        //int[] sonuc = SesliSessizHarfAdedi("Turk");
        //Console.WriteLine(sonuc[0]);
        //Console.WriteLine(sonuc[1]);




        //int[] sayilar = SayiUret(2,1,101);
        //foreach (var item in sayilar)
        //{
        //    Console.WriteLine(item);
        //}





        //SelamVer();
        //Console.WriteLine("Bir cumle giriniz: ");
        //string cumle = Console.ReadLine();

        //int kelimeSayisi=KacKelime(cumle);
        //Console.WriteLine($"'{cumle}' cumlesindeki kelime sayisi: {kelimeSayisi}");

        //int adet = KelimeAdedi("Bugun hava cok guzel. Cok mutluyum.","cok",false);
        //Console.WriteLine(adet);







    }
}

