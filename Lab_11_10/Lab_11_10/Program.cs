using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 256;
            int pad = 8;
            int no = 42;
            ShowPad(no, pad);
        }
        private static void ShowPad(int no, int pad)
        {
            Stack<int> stack = new Stack<int>();
            while (no != 0)
            {
                stack.Push(no%2);
                no /= 2;
            }
            
        }
    }
}
