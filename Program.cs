using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassihoone
{
	class Program
	{
		static void Main(string[] args)
		{
			EraMaja majake = new EraMaja();
			Console.WriteLine("Pindala:");
			majake.Pindala = int.Parse(Console.ReadLine());
			majake.NaitaInf();
			inimene mees = new inimene("Roman Abramovich");
			majake.uks = new Uks("Valge");
			mees.hoone = majake;
			mees.NaitaInfo();
			Console.ReadLine();
		}
	}
}
