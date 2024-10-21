namespace Lab6_OOP_Arv
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// makes an object of each class
			Dog dog = new Dog("Dachshund");
			Chihuahua chihuahua = new Chihuahua("only some");
			Bulldog bulldog = new Bulldog("almost too");
			Cat cat = new Cat("green", "naked");
			Bird bird = new Bird(3, "tweet");

			// calls the MakeSound() method on each object
			dog.MakeSound();
			chihuahua.MakeSound();
			bulldog.MakeSound();
			cat.MakeSound();
			bird.MakeSound();
		}
	}
}
