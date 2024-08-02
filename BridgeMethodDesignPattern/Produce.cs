using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMethodDesignPattern
{
    public class Produce : IWorkshop
    {
        public void Work()
        {
            Console.Write("Produced");
        }
    }
}
