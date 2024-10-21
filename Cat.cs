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

		// Cat() requires eyeColor and skinType as arguments and sends default values to the base class Animal()
		public Cat(string eyeColor, string skinType = "fur")
			: base(skinType, "legs", 2, "nose", true)
		{
			EyeColor = eyeColor;
		}

		// overrides Animal.Eat()
		public override void Eat()
		{
			Console.WriteLine($"The {EyeColor} eyed cat is eating cat food.");
		}

		// overrides Animal.Sleep()
		public override void Sleep()
		{
			Console.WriteLine($"The {EyeColor} eyed cat is napping in a sunny spot.");
		}

		// overrides Animal.MakeSound()
		public override void MakeSound()
		{
			Console.WriteLine($"The {EyeColor} eyed cat meows.");
		}
	}
}
