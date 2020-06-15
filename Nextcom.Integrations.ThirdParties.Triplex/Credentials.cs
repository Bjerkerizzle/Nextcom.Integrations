using System;
using System.Collections.Generic;
using System.Text;

namespace Nextcom.Integrations.ThirdParties.Tripletex
{
    public class Credentials
    {
        public string ConsumerToken { get; set; }
        public string EmployeeToken { get; set; }
        public string ExpirationDate { get; set; }

        public Credentials()
        {
        }

        public Credentials(string consumer, string employee)
        {
            ConsumerToken = consumer;
            EmployeeToken = employee;
            ExpirationDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
        }
    }
}
