using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configuracion
{
    static public class Utils
    {
        public static int generarIdRandom()
        {
            int iSeed = 10;
            Random ro = new Random(iSeed);
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            return ran.Next();
        }
    }
}
