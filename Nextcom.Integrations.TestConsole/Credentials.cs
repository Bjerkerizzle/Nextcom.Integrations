using System;
using System.Collections.Generic;
using System.Text;

namespace Nextcom.Integrations.TestConsole
{
    public class Credentials
    {
        public string ConsumerToken { get; set; }
        public string EmployeeToken { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Credentials()
        {
        }

        public Credentials(string consumer, string employee)
        {
            ConsumerToken = consumer;
            EmployeeToken = employee;
            ExpirationDate = DateTime.Now;
        }
    }
}
