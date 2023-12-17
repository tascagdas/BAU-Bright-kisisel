namespace P04_Inheritance;
public class Alive
{
    public string Category { get; set; }
}
public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    //eger bu metodu miras olarak alan siniflarda teniden yazilabilmesine izin vermek istiyorsak virtual keywordu ile isaretlenir.
    public virtual void Intro()
    {
        Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}");
    }
}
public class Student : Person
{
    public int StudentNumber { get; set; }
}
public class Teacher:Person
{
    public string Branch { get; set; }
    public override void Intro()
    {
        Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Branch: {Branch}");

    }
}
class Program
{
    static void Main(string[] args)
    {
        //Student student1 = new Student();
        //Teacher teacher1 = new Teacher();
        //teacher1.FirstName = "Engin Niyazi";
        //teacher1.LastName = "Ergul";
        //teacher1.Branch = "C#";
        //teacher1.Intro();


        Base nesne = new Base();
    }
}