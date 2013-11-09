using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityComponentSystem;

namespace SimpleCommandLine
{
    public class Program
    {
        static void Main(string[] args)
        {
            var systemsManager = new SystemsManager();

            while (true)
            {
                systemsManager.Update(0);
            }
        }
    }
}
