using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMethodDesignPattern
{
    public abstract class Vehicle
    {
        public IWorkshop workshop1;
        public IWorkshop workshop2;

        public Vehicle(IWorkshop workshop1,IWorkshop workshop2)
        {
            this.workshop1 = workshop1;
            this.workshop2 = workshop2;
        }
        public abstract void Manufacture();
    }
}
