using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    
    public enum TaskCategory {
        None = 0,
        Work = 1,
        Personal = 2,
        Shopping = 4,
        A2SV = 8,
        Spritual = 16,
    }
    public class UserTasks
    {
        public Guid TaskId { get; init; } = Guid.NewGuid();
        public  string TaskName { get; init; }
        public string TaskDescription { get; init; }
        
        public TaskCategory TaskCategory { get; private set; }

        public bool IsCompleted { get; set; } = false;


        public void AddCategory(string[] category)
        {
            foreach (string categoryName in category)
            {
                if (Enum.TryParse<TaskCategory>(categoryName, out TaskCategory cat))
                {
                    TaskCategory |= cat;
                }
            }
        }
    }