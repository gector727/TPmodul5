using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPmodul5_103082400004
{
    internal class HaloGeneric
    {
        public void SapaUser<T>(T X)
        {
            Console.WriteLine("Halo user " + X);
        }
    }
}
