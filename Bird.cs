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

		public Bird(double wingSpan, string sound = "chirp")
			: base("feathers", "wings", 0, "beak", true)
		{
			WingSpan = wingSpan;
			Sound = sound;
		}

		public override void Eat()
		{
			Console.WriteLine("The bird is pecking at seeds.");
		}

		public override void Sleep()
		{
			Console.WriteLine("The bird is sleeping on a perch.");
		}

		public override void MakeSound()
		{
			Console.WriteLine($"The bird {Sound}s.");
		}
	}
}
