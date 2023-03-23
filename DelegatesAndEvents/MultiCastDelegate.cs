using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int MultiOperation(int x, int y);
    public class MultiCastDelegate
    {

        public int Addition(int x, int y)
        {
            Console.WriteLine("Add: " + (x + y));
            return x + y;
        }
        public int Multiplication(int x, int y)
        {
            Console.WriteLine("Mul: " + (x * y));
            return x * y;
        }
        public void Run()
        {
            MultiOperation multiOperation = new MultiOperation(Addition);
            multiOperation += new MultiOperation(Multiplication);
            multiOperation(1, 2);
            multiOperation(3, 4);
        }
    }
}
