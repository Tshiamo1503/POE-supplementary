using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    class Gold: Item
    {
        private Random ran = new Random();
        public int AmountG { get; set; }
        public Gold(int X, int Y) : base(X, Y)
        {
            AmountG = ran.Next(1, 6);
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
