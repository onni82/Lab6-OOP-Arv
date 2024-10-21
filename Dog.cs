using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv
{
	public class Dog : Animal
	{
		public string Breed { get; set; }

		// Dog() requires breed as an argument and sends default values to the base class Animal()
		public Dog(string breed)
			: base("fur", "legs", 2, "snout", true)
		{
			Breed = breed;
		}

		// overrides Animal.Eat()
		public override void Eat()
		{
			Console.WriteLine($"The {Breed} is eating dog food.");
		}

		// overrides Animal.Sleep()
		public override void Sleep()
		{
			Console.WriteLine($"The {Breed} is sleeping in its bed.");
		}

		// overrides Animal.MakeSound()
		public override void MakeSound()
		{
			Console.WriteLine($"The {Breed} barks.");
		}
	}
	public class Chihuahua : Dog
	{
		public string Sass { get; set; }
		public Chihuahua(string sass = "a lot of")
			: base("chihuahua")
		{
			Sass = sass;
		}

		// this method taunts everyone and prints Sass level
		public void Taunt()
		{
			Console.WriteLine($"The chihuahua taunts everyone with {Sass} sass.");
		}
	}
	public class Bulldog : Dog
	{
		public string Friendly { get; set; }
		public Bulldog(string friendly = "very")
			: base("Bulldog")
		{
			Friendly = friendly;
		}

		// this method makes the bulldog play and prints its Friendly variable
		public void Play()
		{
			Console.WriteLine($"The bulldog plays with all the nearby people. The dog is {Friendly} friendly.");
		}
	}
}
