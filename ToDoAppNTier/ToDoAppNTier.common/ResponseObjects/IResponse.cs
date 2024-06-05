using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppNTier.common.ResponseObjects
{
    public class IResponse
    {
        public string message { get; set; }

        public ResponseType ResponseType { get; set; }
    }
}
