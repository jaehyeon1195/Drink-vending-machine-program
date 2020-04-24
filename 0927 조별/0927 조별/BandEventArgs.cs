using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0927_조별
{
    class BandEventArgs
    {
        public string Type { get; private set; }
        public string Item { get; private set; }
        public int Price { get; private set; }
        public int Balance { get; private set; }
        public DateTime date { get; private set; }

        public BandEventArgs(string t,string i, int n1, int n2)
        {
            Type = t;
            Item = i;
            Price = n1;
            Balance = n2;   
            date = DateTime.Now;
        }
    }

    delegate void BandEvent(object obj, BandEventArgs arg);
}

