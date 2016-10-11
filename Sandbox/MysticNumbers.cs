using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class MysticNumbers
    {
        public MysticNumbers()
        {

        }

        public int ThreeNumbers(int a, int b, int c)
        {
            int result;

            if (b > a)
            {
                result = b;
                if (c > b)
                {
                    result = c;
                }
            }
            else
            {
                result = a;
                if (c > a)
                {
                    result = c;
                }
            }

            return result;
        }

        /// <summary>
        /// Returnerer det højeste tal af 2 tal. (omskrevet ThreeNumbers metode)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int TwoNumbers(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a;
                
            }
            else
            {
                result = b;
            }

            return result;
            
        }
    }
}
