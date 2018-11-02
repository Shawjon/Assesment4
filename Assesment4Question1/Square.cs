using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment4
{
    class Square : IShape
    {
        private int Side;
        public Square()
        {
            Side = 0;
        }
        public Square(int side)
        {
            Side = side;
        }

        public int side { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Hi, I am a square!");
        }
        public int GetArea()
        {
            return Side * Side;
        }
    }
}
