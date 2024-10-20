using Spectre.Console;
namespace Lab6_OOP_Arv
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dog dog = new Dog("Dachshund", "fur", "legs", 2, "snout", true);
			Chihuahua chihuahua = new Chihuahua();
			Bulldog bulldog = new Bulldog();
			Cat cat = new Cat();
			Bird bird = new Bird();
		}
	}
}
