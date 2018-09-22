using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Domain.Helpers
{
    public class OperationResult
    {
        public OperationResult()
        {

        }

        public OperationResult(bool success, string message) : this()
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
