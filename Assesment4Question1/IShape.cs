using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment4
{
    class IShape
    {
        public IShape()
        {
        }
        public virtual void Draw()
        {
            Console.WriteLine("Hi, I am a shape");
        }
    }
}
