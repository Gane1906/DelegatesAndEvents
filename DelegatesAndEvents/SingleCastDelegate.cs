using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int Arithmetic(int x, int y);
    public class SingleCastDelegate
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }
        public void Run()
        {
            Arithmetic arithmetic = new Arithmetic(Addition);
            Console.WriteLine(arithmetic(1, 2));
        }
        
       
            
    }
}
