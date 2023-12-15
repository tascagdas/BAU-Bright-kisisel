namespace P09_Conditions;

class Program
{
    static void Main(string[] args)
    {
        #region If Intro
        //Console.WriteLine("Yaş: ");
        //int age = int.Parse(Console.ReadLine());
        //if (age>=18)
        //{
        //    Console.WriteLine("Giriş Ok!");
        //}
        //else
        //{
        //    Console.WriteLine("Giriş No!");
        //}
        #endregion
        #region Tek satır If
        //if (true) Console.WriteLine("Doğru");
        #endregion
        #region If ElseIf
        //int age = 45;
        //if (age<18)
        //{
        //    Console.WriteLine("Çocuk");
        //}else if(age<40){
        //    Console.WriteLine("Genç");
        //}
        //else
        //{
        //    Console.WriteLine("Yaşlı");
        //}
        #endregion
        #region TernaryIf

        #endregion
        #region SwitchCase
        //int x = 25;
        //switch (x)
        //{
        //    case 5:
        //        Console.WriteLine("Bugun 5");
        //        break;
        //    case 10:
        //        Console.WriteLine("Bugun 10");
        //        break;
        //    case 15:
        //        Console.WriteLine("Bugun 15");
        //        break;
        //    case 20:
        //        Console.WriteLine("Bugun 20");
        //        break;
        //    default:
        //        Console.WriteLine("Söyleyecek bir şey yok");
        //        break;
        //}
        #endregion
        #region SwitchCase2
        int x = 6;
        switch (x)
        {
            case 5:
            case 10:
            case 15:
            case 20:
            case 25:
            case 30:
                Console.WriteLine("5in katı");
                break;

            default:
                Console.WriteLine("Söyleyecek bir şey yok");
                break;
        }
        #endregion
    }
}

