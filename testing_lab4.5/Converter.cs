using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_lab4._5
{
    public class Converter
    {
        public static int Do(float x)
        {

            if (x * 10 == (float)Math.Round(x, 1) * 10)
            {
                if (x > 100.6f)
                {
                    return 1000;
                }
                else if (x > 0 && x < 100.7f)
                {
                    return (int)x;
                }
                else if (x == 0)
                {
                    throw new ArgumentException("Число не может быть 0");
                }
                else if (x < 0 && x >= -30.4f)
                {
                    return (int)x - 5;
                }
                else if (x <= -30.5f)
                {
                    return -2000;
                }
            }
                throw new ArgumentException("Число должно быть с одним знаком после запятой");
        }
    }
}
