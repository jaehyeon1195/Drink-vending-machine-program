using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0927_조별
{
    class EventLog
    {
        private List<BandEventArgs> loglist = new List<BandEventArgs>();
        Banding ban = null;

        public EventLog(Banding b)
        {
            ban = b;
            ban.log += LogMessage;
        }

        public void LogMessage(object obj, BandEventArgs e)
        {
            loglist.Add(e);
            //PrintAll();
        }

        public void PrintAll()
        {
            Console.WriteLine("----------------------------------------------------------------");
            foreach (BandEventArgs a in loglist)
            {
                Console.WriteLine("[{0}] {1}, {2},{3},{4}", a.Type, a.Item, a.Price, a.Balance, a.date);
            }
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
