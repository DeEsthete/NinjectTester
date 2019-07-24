using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectTester.Models
{
    public class EmailSender : ISender
    {
        public string Send(string message)
        {
            return "EmailSender отправил: " + message;
        }
    }
}