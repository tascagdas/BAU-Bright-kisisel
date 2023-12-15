namespace P05_Methods_01;

class Program
{
    static void Main(string[] args)
    {
        #region String Methods
        //string name = "Cagdas Tas";

        //int len = name.Length;
        //Console.WriteLine(name+" metninin uzunlugu "+len+" karakterdir");

        //Console.WriteLine(name.ToUpper());
        //Console.WriteLine(name.ToLower());


        //string m1 = "Bahcesehir";
        //string m2 = "Universitesi";
        //int year = 1996;
        //Console.WriteLine(m1+m2);
        //Console.WriteLine(String.Concat(m1," ",m2));
        //string result = $"{m1} {m2} {year} yilinda kurulmustur.";
        //Console.WriteLine(result);

        //string name = "ece";
        //int age = 13;
        //string school = "Yeditepe IOO";
        //string result = $"Ad: {name}\nYas: {age}\nOkul: {school}";
        //Console.WriteLine(result);
        //Console.WriteLine($"{name}\t{age}\t{school}");


        //string courseName = "Fullstack Web Developer Egitimi";
        //string findText = "web";
        //bool result = courseName.ToLower().Contains(findText.ToLower());
        //Console.WriteLine(result );


        //string name = "zeyno";
        //Console.WriteLine(name.IndexOf("y"));
        //Console.WriteLine(name.StartsWith("z"));
        //Console.WriteLine(name.EndsWith("no"));

        //string school = "Yildiz Teknik Universitesi";
        //string result = school.Replace("Universitesi", "Uni");
        //Console.WriteLine(result);


        //string title = "C#'ta metinsel islemler";
        //Console.WriteLine(title.Replace(" ","-").ToLower());
        //string text = "Bugun hava cok guzeldi. Ama aksama dogru,hava bozdu. Oyle bozdu. Oyle bozdu ki. Dahada bozmaz dedik, dahada bozdu.";
        //Console.WriteLine(text.Replace(",",""));

        string title = "Tesla, 2 milyondan fazla aracı otopilot yazılımını güncellemek için geri çağıracak!";
        title = title.ToLower();
        title = title.Replace(" ", "-");
        title = title.Replace(",", "");
        title = title.Replace("'", "");
        title = title.Replace("ı", "i");
        title = title.Replace("ç", "c");
        title = title.Replace("ğ", "g");
        title = title.Replace("ş", "s");
        title = title.Replace("ü", "u");
        title = title.Replace("!", "");





        Console.WriteLine(title);


        #endregion
        Console.ReadLine();
    }
}

