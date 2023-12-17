namespace P08_ErrorHandling;

class Program
{
    static void Main(string[] args)
    {
        #region Intro
        /*
 * uygulamalarımız çalıştıkları esnada bir takım hatalardan dolayı durabilir.
 * bu tür hatalara run time errors denir.
 * runtime errors'ı kontrol altına alabilmek için try-catch-finally yapısını kullanacağız.
 * 
 * 
 * try
 * {
 * hata verme ihtimali olan kodları bu kısma yazacağız.
 * Dolayısı ile buraya yazdığımız kodları şu şekilde düşünebiliriz. BU KODLARI ÇALIŞTIRMAYI DENE. Çalışıyorsa hiçbir sorun olmadan devam eder. Çalışmıyorsa hata varsa catch scopeuna atlar.
 * }
 * catch{
 * Eğer try scope'undaki kodda bir hata meydana gelirse Bu kısımdaki kodlar çalışır.
 * }
 * finally
 * {
 * try yada catch scopelarından hangisi çalışmış olursa olsun her halükarda bu scopedaki kodlar çalışır.    
 * }
 * 
 * 
 */
        #endregion
        #region Sample01
        //Console.Write("Lütfen karesi alınacak sayıyı giriniz:");
        //try
        //{
        //    int sayi = Convert.ToInt32(Console.ReadLine());
        //    int sonuc = Convert.ToInt32(Math.Pow(sayi, 2));
        //    Console.WriteLine(sonuc);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        #endregion
        #region Sample02
        try
        {
            Console.Write("Bölünen: ");
            int bolunen = int.Parse(Console.ReadLine());
            Console.Write("Bölen: ");
            int bolen = int.Parse(Console.ReadLine());
            int sonuc = bolunen / bolen;
            Console.WriteLine($"{bolunen}/{bolen}={sonuc}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("0'a bölme yapılamaz!");
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Geçersiz bir sayı girdiniz!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        #endregion
    }
}

