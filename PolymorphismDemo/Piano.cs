using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Piano:Instrument
    {
        public override void Play()
        {
            Console.WriteLine("The piano is playing");
        }

    }
}
