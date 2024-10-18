using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv
{
	public class Cat : Animal
	{
		public string EyeColor { get; set; }

		public Cat(string eyeColor, string skinType = "fur", string locomotorOrgan = "legs", int ears = 2, string breathingOrgan = "nose", bool hasTail = true)
			: base(skinType, locomotorOrgan, ears, breathingOrgan, hasTail)
		{
			EyeColor = eyeColor;
		}

		public override void Eat()
		{
			Console.WriteLine("The cat is eating cat food.");
		}

		public override void Sleep()
		{
			Console.WriteLine("The cat is napping in a sunny spot.");
		}

		public override void MakeSound()
		{
			Console.WriteLine("The cat meows.");
		}
	}
}
