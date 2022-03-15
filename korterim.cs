using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassihoone
{
	public class korterim : Hoone
	{
		public korterim(int uks) : base(uks)
		{

		}
		public void NaitaInfo()
		{
			Console.WriteLine($"Olen {uks}!");
		}
	}
}
