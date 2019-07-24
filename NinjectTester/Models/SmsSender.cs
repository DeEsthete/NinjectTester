using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectTester.Models
{
    public class SmsSender : ISender
    {
        public string Send(string message)
        {
            return "SmsSender отправил: " + message;
        }
    }
}