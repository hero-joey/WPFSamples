using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlViewSample
{
    class EmployeeCollection : ObservableCollection<EmployeeInfo>
    {
        public EmployeeCollection()
        {
            Add(new EmployeeInfo("Zi", "Zhang", "HR"));
            Add(new EmployeeInfo("Xiao", "Wang", "IT"));
            Add(new EmployeeInfo("Xiao", "Li", "HR"));
            Add(new EmployeeInfo("Xiao", "Chen", "IT"));
        }
    }
}
