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

		public Dog(string breed, string skinType = "fur", string locomotorOrgan = "legs", int ears = 2, string breathingOrgan = "nose", bool hasTail = true)
			: base(skinType, locomotorOrgan, ears, breathingOrgan, hasTail)
		{
			Breed = breed;
		}

		public override void Eat()
		{
			Console.WriteLine("The dog is eating dog food.");
		}

		public override void Sleep()
		{
			Console.WriteLine("The dog is sleeping in its bed.");
		}

		public override void MakeSound()
		{
			Console.WriteLine("The dog barks.");
		}
	}

}
