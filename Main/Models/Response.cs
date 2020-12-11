using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Models
{
    public class Response
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public Response(bool status, string msg)
        {
            this.Status = status;
            this.Message = msg;
        }
    }
}
