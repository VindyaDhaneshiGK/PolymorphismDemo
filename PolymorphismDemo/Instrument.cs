using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Instrument
    {
        
            public virtual void Play()
            {
                Console.WriteLine("Playing an instrument");
            }
        
    }
}
