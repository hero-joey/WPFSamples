using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBindDataTemplateSample
{
    internal class Task
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int TaskPriority { get; set; }

        public TaskType TaskType { get; set; }
    }

    public enum TaskType
    {
        Work,
        Home
    }
}
