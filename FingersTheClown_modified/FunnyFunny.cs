﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingersTheClown_modified
{
    class FunnyFunny : IClown
    {
        private string funnyThingIHave;
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        
        public string FunnyThingIHave
        {
            get { return "Hi kids! I have " + funnyThingIHave; }
        }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
