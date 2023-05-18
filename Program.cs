namespace Student
{
    public class Program
    {
        public static void PrintMaleStudents(List<Student> students)
        {
            var maleStudents = from student in students
                               where student.Gender == "male"
                               select student;
            foreach (var student in maleStudents)
            {
                student.Print();
            }
        }
        public static void PrintAge(List<Student> students)
        {
            var studentAge = from student in students
                             orderby student.Age descending 
                select student;
            foreach (var student in studentAge)
            {
                student.Print();
            }
        }

        public static void UnivStudents(List<Student> students, int universityId)
        {
            var studentUniversity = from student in students
                                    where student.UniversityId ==universityId
                                    select student;
            foreach (var student in studentUniversity)
            {
                student.Print();
            }
        }
        public static void StudentName(List<Student> students, List<University> universities )
        {
            var query = from student in students
                              join university in universities on student.UniversityId
                              equals university.Id
                              select new { StudentName = student.Name, UniversityName = university.Name };
            foreach(var result in query)
            {
                Console.WriteLine("Student {0} from University {1}", result.StudentName, result.UniversityName);
            }
        }
        public static void StudentAgeUniversity(List<Student>students, List<University>universities)
        {
            var query = from student in students
                        join university in universities on student.UniversityId
                              equals university.Id
                        orderby student.Age ascending
                        select new {StudentAge= student.Age, StudentName = student.Name, UniversityName = university.Name };
            foreach(var result in query)
            {
                Console.WriteLine("Age {0}, Student {1} from University {2} ", result.StudentAge, result.StudentName, result.UniversityName);
            }
        }
        //public static void 
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Jean", Id = 1, Gender = "male", Age = 22, UniversityId = 3 },
                new Student { Name = "Lucie", Id = 2, Gender = "female", Age = 20, UniversityId = 3 },
                new Student { Name = "Thomas", Id = 3, Gender = "male", Age = 20, UniversityId = 4 },
                new Student { Name = "Marie", Id = 4, Gender = "female", Age = 23, UniversityId = 4 }
            };
            // PrintMaleStudents(students);
            //PrintAge(students);
            // UnivStudents(students, 3);
          

            List<University> universities = new List<University>
            {
                new University {Name= "Pierre et Marie Curie", Id=3},
                new University {Name="Claude Bernard", Id=4},
            };
           // StudentName(students, universities);
            StudentAgeUniversity(students, universities);
        }
    }
}

