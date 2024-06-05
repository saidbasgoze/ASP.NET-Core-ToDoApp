using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppNTier.common.ResponseObjects
{
    public class Response : IResponse
    {
        public Response( ResponseType responseType ) { 
            ResponseType = responseType;
        }

        public Response(ResponseType responseType, string message) {
            ResponseType = responseType;

            message = message;

        }
        public string message { get; set; }

        public ResponseType ResponseType { get; set; }
    }
    public enum ResponseType
    {
        Success,
        ValidationError,
        NotFound
    }
}
