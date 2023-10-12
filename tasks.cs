using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApp1
{
    class Task: ITask
    {
        private string Name { get; set; }
        private string Description { get; set; }
        public Task(string name)
        {
            Name = name;
            Description = "aa";
        }
        public void remove() { }
        public void create(string input) 
        {
            File.AppendAllText("tasks.txt", input);
        }
        public void dothis() { }
        public void seemore() { }
    }

    class tasks
    {


    }
}
