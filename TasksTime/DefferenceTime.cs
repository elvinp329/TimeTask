using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksTime
{
    internal class DefferenceTime
    {
        internal string Defference(string time1, string time2, out string time3)
        {

            int h1 = int.Parse(time1.Substring(0, 2));
            int m1 = int.Parse(time1.Substring(3, 2));
            int s1 = int.Parse(time1.Substring(6, 2));

            int h2 = int.Parse(time2.Substring(0, 2));
            int m2 = int.Parse(time2.Substring(3, 2));
            int s2 = int.Parse(time2.Substring(6, 2));

            int h3, m3, s3;

            s3 = s2 - s1;

            if (s2 < s1)


            {           
                s3 = (s2 + 60) - s1;
                m2 = m2 - 1; 
            }

            m3 = m2 - m1;

            if (m2 < m1)
            {
                m3 = (m2 + 60) - m1;
                h2 = h2 - 1; 
            }

            h3 = h2 - h1;

            if (h2 < h1)

            { h3 = (h2 + 24) - h1;
            }

            string x = h3.ToString();
            string y = m3.ToString();
            string z = s3.ToString();

            if (h3 < 10 || m3 < 10 || s3 < 10)
            {
                x = h3.ToString().PadLeft(2, '0');
                y = m3.ToString().PadLeft(2, '0');
                z = s3.ToString().PadLeft(2, '0');
            }



            time3 = ($"{x}:{y}:{z}");

            return time3;


        }

    }
}
