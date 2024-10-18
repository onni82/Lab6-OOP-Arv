using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv
{
	public abstract class Animal
	{
		public string Skintype { get; set; }
		public string LocomotorOrgan { get; set; }
		public int Ears { get; set; }
		public string BreathingOrgan { get; set; }
		public bool HasTail { get; set; }

		public Animal(string skinType = "skin", string locomotorOrgan = "legs", int ears = "2", string breathingOrgan = "nose", bool hasTail = false)
        {
			Skintype = skinType;
			LocomotorOrgan = locomotorOrgan;
			Ears = ears;
			BreathingOrgan = breathingOrgan;
			HasTail = hasTail;
        }

		public abstract void Eat();
		public abstract void Sleep();
		public abstract void MakeSound();
    }


}
