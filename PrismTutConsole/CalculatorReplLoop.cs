using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTutConsole
{
    public class CalculatorReplLoop
    {
        public CalculatorReplLoop()
        {
            inputService = new ConsoleInputService();
            outputService = new ConsoleOutputService();
            calculator = new Calulator();
            inputParserService = new InputParserService();

        }
        public void Run()
        {
            while (true)
            {
                string command = inputService.ReadCommand();

                try
                {
                    CommandTypes commandType =inputParserService.ParseCommand(command);
                    Arguments args = inputService.ReadArguments();

                    outputService.WriteMessage(calculator.Execute(commandType, args).ToString());

                }
                catch 
                {

                    outputService.WriteMessage("Mistake");
                }

            }


            
        }

        ConsoleInputService inputService;
        ConsoleOutputService outputService;
        Calulator calculator;
        InputParserService inputParserService;
    }
}
