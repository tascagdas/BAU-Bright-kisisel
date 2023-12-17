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
        //int[] numbers = { 1, 2, 3, 4, 5, 6 };
        //int[] newnumbers = new int[5];
        //int index = 0;

        //foreach (var number in numbers)
        //{
        //    newnumbers[index] = number * 2;
        //    index++;
        //}



        //Klavyeden girilecek bir sayiya kadar olan sayilarin icinden kac tanesinin cift kac tanesinin ucun kati oldugunu buldurup konsola yazdirin.


        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int evenNumberCount = 0;
        int multipleThreeCount = 0;

        for (int i = 0; i <= number; i++)
        {
            if (i % 2 == 0) evenNumberCount++;
            if (i % 3 == 0) multipleThreeCount++;
        }
        Console.Clear();
        Console.WriteLine("Result:");
        Console.WriteLine("-------");
        Console.WriteLine($"between 0-{number} there is {evenNumberCount} even number and {multipleThreeCount} number which is dividable to 3");




        #endregion
        Console.ReadLine();
    }
}

