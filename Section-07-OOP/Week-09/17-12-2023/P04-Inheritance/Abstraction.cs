namespace P04_Inheritance
{
	public abstract class Base
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsActive { get; set; }
		public DateTime CreatedDate { get; set; }
		public abstract void Intro();
		public void Greeting()
		{
			Console.WriteLine("Merhaba!");
		}

	}
	public class Category : Base
	{
		public string Description { get; set; }

        public override void Intro()
        {
            throw new NotImplementedException();
        }
    }
	public class Product : Base
	{
		public string Properties { get; set; }
		public double Price { get; set; }

        public override void Intro()
        {
            throw new NotImplementedException();
        }
    }
	public class Abstraction
	{

	}
}

