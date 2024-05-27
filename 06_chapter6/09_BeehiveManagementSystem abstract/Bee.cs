using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BeehiveManagementSystem
{
    abstract internal class Bee
    {
        public string Job { get; private set; }

        public abstract float CostPerShift { get; }
        public Bee(string job)
        {
            Job = job;
        }
        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
                DoJob();
        }
        abstract protected void DoJob();
    }
}
