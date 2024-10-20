using Spectre.Console;
namespace Lab6_OOP_Arv
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dog dog = new Dog("Dachshund");
			Chihuahua chihuahua = new Chihuahua("only some");
			Bulldog bulldog = new Bulldog("very much");
			Cat cat = new Cat("green", "naked");
			Bird bird = new Bird(3, "tweet");
		}
	}
}
