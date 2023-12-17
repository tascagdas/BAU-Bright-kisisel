using System.Xml.Linq;

namespace P05_Interface;

public interface IPerson
{
    public string Department { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public void Info();
    
}

public interface IPersonal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public interface IEmployee
{
    public string SubDepartment { get; set; }
}

public class Admin : IPerson, IPersonal
{
    public string Department { get; set; }
    public string Address { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get ; set; }

    public void Info()
    {
        Console.WriteLine($"{City}");
    }
}

public class Guest : IPersonal
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
public class Employee : IPerson, IPersonal, IEmployee
{
    public string Department { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string SubDepartment { get; set; }
    public void Info()
    {
        Console.WriteLine($"City: {City} Sub Department: {SubDepartment}");
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Admin admin = new Admin();
        admin.City = "Kars";
        admin.Info();

        Employee employee1 = new Employee();
        employee1.City = "Bartin";
        employee1.SubDepartment = "I.T.";
        employee1.Info();



        /*
         * Bir class sadece bir classtan miras alabilir
         * 
         * Abstrack class yada interfaceden yeni bir nesne uretilemez. (new kullanilamaz)
         * 
         * Bir abstract class icinde hem soyut hem somut memberlar bulunabilir
         * Dolayisi ile bir abstract classa hem soyut hemde somut memberlarimiz varsa ihtiyac duyariz. eger sadece soyut yapilara ihtiyacimiz varsa interface kullaniriz.
         * Yani bir interface icerisindeki tum memberlar soyuttur.
         * 
         * Eger bir class hem interface hemde classtan miras alicaksa once class ismi yazilmak zorundadir.Sonrasinda birden fazla interface yazilarak implamente edilebilir.
         * 
         */

    }
}

