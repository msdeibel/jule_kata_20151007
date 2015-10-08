using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jule_kata_20151007
{
    public class RollResult
    {
        protected int die1;
        protected int die2;
        protected int die3;

        protected RollResult()
        { 
            //void
        }

        public RollResult(int die1Result, int die2Result, int die3Result)
        {
            die1 = die1Result;
            die2 = die2Result;
            die3 = die3Result;
        }

        public int Die1()
        {
            return die1;
        }

        public int Die2()
        {
            return die2;
        }

        public int Die3()
        {
            return die3;
        }
    }
}
