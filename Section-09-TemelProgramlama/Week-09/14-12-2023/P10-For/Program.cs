namespace P10_For;

class Program
{
    static void Main(string[] args)
    {
        #region Intro
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("Hi!");
        //}
        #endregion
        #region ForEach
        //string[] names = { "Ayşenur", "Zeynep", "Ece", "Ferda", "Murat" };
        //foreach (string x in names)
        //{
        //    Console.WriteLine(x);
        //}
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        int[] newnumbers = new int[5];
        int index = 0;

        foreach (var number in numbers)
        {
            newnumbers[index] = number * 2;
            index++;
        }
        #endregion
        Console.ReadLine();
    }
}

