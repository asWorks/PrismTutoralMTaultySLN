﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTutConsole
{
    public class ConsoleInputService
    {
        public string ReadCommand()
        {
            return Console.ReadLine();
        }

        public Arguments ReadArguments()
        {
            int x = int.Parse(Console.ReadLine());
            int y= int.Parse(Console.ReadLine());
            return new Arguments { x = x, y = y };

        }
    }
}
