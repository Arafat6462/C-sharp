using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_3
{
    public class B
    {
        private int x;
        public int y;

        public B(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X { get => x; }
        public int Y { get => y; }
    }
    class Program : B
    {
        private int z;
        public Program(int x, int y, int z) : base(x,y)
        {
            base.y = z;
        }

        public int Z { get => z; }
        static void Main(string[] args)
        {
            Program program = new Program(1, 2, 3);
            Console.WriteLine(program.Z + program.Y);
            Console.ReadKey();
        }
    }
}
