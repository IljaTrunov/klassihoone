using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassihoone
{
	public class Hoone
	{
		public int Pindala { get; set; }
		public Uks uks;

		public Hoone(int pindala = 200)
		{
			Pindala = pindala;
		}

		public void NaitaInfo()
		{
			Console.WriteLine($"Maja pindala on {Pindala} m2");
		}

		public Uks GetUks()
		{
			return uks;
		}
	}

}

