using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv
{
	public class Bird : Animal
	{
		public double WingSpan { get; set; }
		public string Sound { get; set; }

		// Bird() requires wingSpan and sound as arguments and sends default values to the base class Animal()
		public Bird(double wingSpan, string sound = "chirp")
			: base("feathers", "wings", 0, "beak", true)
		{
			WingSpan = wingSpan;
			Sound = sound;
		}

		// overrides Animal.Eat()
		public override void Eat()
		{
			Console.WriteLine("The bird is pecking at seeds.");
		}

		// overrides Animal.Sleep()
		public override void Sleep()
		{
			Console.WriteLine("The bird is sleeping on a perch.");
		}

		// overrides Animal.MakeSound()
		public override void MakeSound()
		{
			Console.WriteLine($"The bird {Sound}s.");
		}

		// this method makes the bird fly
		public void Fly()
		{
			Console.WriteLine($"The bird flies with a wing span of {WingSpan} centimetres.");
		}
	}
}
