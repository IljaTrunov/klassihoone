using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassihoone
{
	public class EraMaja : Hoone
	{
		string info;
		public EraMaja(int pindala = 46) : base(pindala)
		{
			if (Pindala < 25)
			{
				info = "vaike maja";
			}
			else if (Pindala < 40)
			{
				info = "keskmine maja";
			}
			else if (Pindala < 75)
			{
				info = "suur maja";
			}
			else
			{
				info = "liiga suur maja";
			}
		}
		public string Info
		{
			get { return info; }
		}
		public void NaitaInf()
		{
			Console.WriteLine($"Oli {info}, pindala on {Pindala} m2");
		}
	}
}
