using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public void Print()
        {
            Console.WriteLine("University name {0} with id {1}", Id, Name);

        }
    }   
}
