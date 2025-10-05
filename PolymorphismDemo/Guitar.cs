using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Guitar : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("The guitar is playing");
        }
    }
}
