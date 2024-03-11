using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBindDataTemplateSample
{
    internal class TaskViewModel : ObservableCollection<Task>
    {
        public TaskViewModel()
        {
            Add(new Task { TaskName = "Task 1", TaskDescription = "Task 1 Description", TaskPriority = 1, TaskType = TaskType.Work });
            Add(new Task { TaskName = "Task 2", TaskDescription = "Task 2 Description", TaskPriority = 2, TaskType = TaskType.Home });
            Add(new Task { TaskName = "Task 3", TaskDescription = "Task 3 Description", TaskPriority = 3, TaskType = TaskType.Work });
            Add(new Task { TaskName = "Task 4", TaskDescription = "Task 4 Description", TaskPriority = 4, TaskType = TaskType.Home });
            Add(new Task { TaskName = "Task 5", TaskDescription = "Task 5 Description", TaskPriority = 5, TaskType = TaskType.Work });
        }
    }
}
