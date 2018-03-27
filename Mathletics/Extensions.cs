using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathletics
{
    public static class Extensions
    {
        public static double ToDegrees(this double rad)
        {
            return rad * (180.0 / Math.PI);
        }

        public static double ToRadian(this double ang)
        {
            return Math.PI * ang / 180.0;
        }

        public static double Round(this double d, int decimalPlaces)
        {
            return (double)decimal.Round((decimal)d, decimalPlaces, MidpointRounding.AwayFromZero);
        }

        public static IEnumerable<Control> GetAllControls(Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);

                yield return next;
            }
        }
    }
}
