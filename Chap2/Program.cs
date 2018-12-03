using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap2
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMethod();
        }

        private static void StartMethod()
        {
            Thread monitorThread = new Thread(new ThreadStart(MonitorNetwork));
            monitorThread.Start();
        }

        private static void MonitorNetwork()
        {
            //throw new NotImplementedException();
        }
    }
}
