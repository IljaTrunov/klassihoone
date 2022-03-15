using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassihoone
{
	public class inimene
    {
        private string nimi;
        public Hoone hoone { get; set; }

        public inimene(string nimi)
        {
            this.nimi = nimi;
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Minu nimu on {nimi}");
            Console.WriteLine("Hoone info:");
            hoone.NaitaInfo();
            Console.WriteLine("Ukse info:");
            hoone.GetUks().NaitaInfo();
        }
    }
}
