using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnaTrid
{
    public class Pole
    {
        public static int[] Nacti(int n, int dol = 1, int hor = 100)
        {
            Random rn = new Random();
            int[] p = new int[n];
            for (int i = 0; i < p.Length; i++)
            {
                int x = rn.Next(dol, hor);
                p[i] = x;

            }
            return p;
        }
    }
}
