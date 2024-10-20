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

		public Dog(string breed)
			: base("fur", "legs", 2, "snout", true)
		{
			Breed = breed;
		}

		public override void Eat()
		{
			Console.WriteLine($"The {Breed} is eating dog food.");
		}

		public override void Sleep()
		{
			Console.WriteLine($"The {Breed} is sleeping in its bed.");
		}

		public override void MakeSound()
		{
			Console.WriteLine($"The {Breed} barks.");
		}
	}
	public class Chihuahua : Dog
	{
		public string Sass { get; set; }
		public Chihuahua(string sass = "a lot")
			: base("chihuahua")
		{
			Sass = sass;
		}

		public void Taunt()
		{
			Console.WriteLine($"The chihuahua taunts everyone aggressively with {Sass} of sass.");
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

		public void Play()
		{
			Console.WriteLine($"The bulldog plays with all the nearby children. The dog is {Friendly} friendly.");
		}
	}
}
