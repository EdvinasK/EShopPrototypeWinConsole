using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Common
{
    public static class LoggingService
    {
        public static string LogAction(string action)
        {
            var logText = "Action: " + action;
            Console.WriteLine(logText);

            return logText;
        }
    }
}
