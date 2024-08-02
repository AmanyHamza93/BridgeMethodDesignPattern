using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMethodDesignPattern
{
    public class Bike : Vehicle
    {
        public Bike(IWorkshop workshop1, IWorkshop workshop2) : base(workshop1, workshop2)
        {
        }
        public override void Manufacture()
        {
            Console.Write("Bike ");
            workshop1.Work();
            workshop2.Work();
        }
    }
}
