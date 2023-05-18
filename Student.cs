using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public int UniversityId { get; set; }
        public void Print()
        {
            Console.WriteLine("Student {0} with id {1}, Gender {2} and Age {3} from University with Id {4}",
                      Name, Id, Gender, Age, UniversityId);
            
        }
    }
       
    
    
}
