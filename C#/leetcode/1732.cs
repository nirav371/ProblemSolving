using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class _1732
    {
        public int LargestAltitude(int[] gain)
        {
            int altitude = 0;
            int maxAltitude = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                altitude += gain[i];
                maxAltitude = Math.Max(maxAltitude, altitude);
            }
            return maxAltitude;
        }
    }
}
