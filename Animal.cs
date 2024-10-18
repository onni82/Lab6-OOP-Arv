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
		public string Skintype;
		public string LocomotorOrgan;
		public int Ears;
		public string BreathingOrgan;
		public bool HasTail;

        public Animal(string skinType, string locomotorOrgan, int ears, string breathingOrgan, bool hasTail)
        {
			Skintype = skinType;
			LocomotorOrgan = locomotorOrgan;
			Ears = ears;
			BreathingOrgan = breathingOrgan;
			HasTail = hasTail;
        }

		public abstract void Eat();
		public abstract void Sleep();
		public abstract void Move();
    }
}
