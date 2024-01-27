//By Zackary Paulson
using System;

namespace CIS106WEEK1
{
    public class Task
    {
        //Here I'm inserting the properties of the class
        public int TablesToClean { get; set; }
        public Guid TaskId { get; private set; }

        //Here i'm constructing the class
        public Task()
        {
            TaskId = Guid.NewGuid();
        }
    }
}
