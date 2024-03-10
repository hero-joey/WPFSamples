using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlViewSample
{
    class EmployeeInfo
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Department { get; set; }

        public EmployeeInfo(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }
    }
}
