using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingersTheClown
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings)
            : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public string ScaryThingIHave
        {
            get { return "I have " + numberOfScaryThings + " spiders"; }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo! Gotcha!");
        }
    }
}
