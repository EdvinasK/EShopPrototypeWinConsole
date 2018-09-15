using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Common
{
    public static class LoggingService
    {
        /// <summary>
        /// Logs a specified action
        /// </summary>
        /// <param name="action">Action name</param>
        /// <returns>Returns what action was invoked</returns>
        public static string LogAction(string action)
        {
            var logText = "Action: " + action;
            Console.WriteLine(logText);

            return logText;
        }
    }
}
