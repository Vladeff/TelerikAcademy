using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> chiniiMrysni = new Stack<int>();
            chiniiMrysni.Push(1);
            chiniiMrysni.Push(2);
            chiniiMrysni.Push(5);
            chiniiMrysni.Push(7);
            chiniiMrysni.Push(7);
            while (chiniiMrysni.Count != 0)
            {
                Console.WriteLine(chiniiMrysni.Pop());
            }
        }
    }
}
