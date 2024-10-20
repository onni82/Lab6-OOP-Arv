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
	public class Chihuahua : Dog
	{
		public string Sass { get; set; }
		public Chihuahua(string breed = "Chihuahua", string skinType = "fur", string locomotorOrgan = "legs", int ears = 2, string breathingOrgan = "nose", bool hasTail = true, string sass = "a lot")
			: base(breed, skinType, locomotorOrgan, ears, breathingOrgan, hasTail)
		{
			Sass = sass;
		}
	}
	public class Bulldog : Dog
	{
		public string Friendliness { get; set; }
		public Bulldog(string breed = "Bulldog", string skinType = "fur", string locomotorOrgan = "legs", int ears = 2, string breathingOrgan = "nose", bool hasTail = true, string friendliness = "a lot")
			: base(breed, skinType, locomotorOrgan, ears, breathingOrgan, hasTail)
		{
			Friendliness = friendliness;
		}
	}
}
