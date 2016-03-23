using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTutConsole
{
    public class Calulator
    {
        public int Execute(CommandTypes commandType,Arguments args)
        {
            switch (commandType)
            {
                case CommandTypes.Add:
                    return (Add(args));
                case CommandTypes.Sub:
                    return (Sub(args));
                case CommandTypes.Mul:
                    return (Mul(args));
                case CommandTypes.Div:
                    return (Div(args));
                default:
                    throw new InvalidOperationException();
                    
            }
        }
        public  int Add(Arguments args)
        {
            return args.x + args.y;
        }
        public int Sub(Arguments args)
        {
            return args.x - args.y;
        }
        public int Mul(Arguments args)
        {
            return args.x * args.y;
        }
        public  int Div(Arguments args)
        {
            return args.x / args.y;
        }
    }
}
