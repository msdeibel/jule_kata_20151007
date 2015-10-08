using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jule_kata_20151007
{
    public class SixSidedDie
    {
        public int Roll()
        {
            return new Random().Next(1, 6);
        }
    }
}
