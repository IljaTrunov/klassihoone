using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassihoone
{
    public class Uks
    {
        public string Color { get; set; }

        public Uks(string color = "Valge")
        {
            Color = color;
        }
        public void NaitaInfo()
        {
            Console.WriteLine($"Uks värv on {Color}");
        }
    }
}
