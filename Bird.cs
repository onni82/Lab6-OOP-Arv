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

		public Bird(double wingSpan, string skinType = "feathers", string locomotorOrgan = "wings", int ears = 0, string breathingOrgan = "beak", bool hasTail = true)
			: base(skinType, locomotorOrgan, ears, breathingOrgan, hasTail)
		{
			WingSpan = wingSpan;
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
			Console.WriteLine("The bird chirps.");
		}
	}
}
