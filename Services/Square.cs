using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Square
    {
        /// <summary>
        /// Считает квадраное уравнение
        /// </summary>
        /// <param name="a"> первый коф</param>
        /// <param name="b">второй коф</param>
        /// <param name="c">третий коф</param>
        /// <returns>Результат вычислений </returns>
        public static string Calculate(double a, double b, double c)
        {
            if (a == 0) return "иди нахуй, a=0 он тут сделал";
            var dickriminant = (b * b) - 4 * a * c;
            if (dickriminant < 0) return "Корней нет";
            if (dickriminant == 0) return $"{-b / (2 * a)}";
            return $"x1= {(-b+Math.Sqrt(dickriminant))/(2*a)}, x2= {(-b-Math.Sqrt(dickriminant))/(2*a)}";
        }
    }
}
