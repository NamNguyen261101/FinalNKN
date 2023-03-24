using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThiTho
{
    public class StudentFunction
    {
        private List<Student> listStudents = null;

        public StudentFunction()
        {
            listStudents = new List<Student>();
        }
        public void Display()
        {

            Console.WriteLine(" 1.Input information(input details for a student).");
            Console.WriteLine(" 2.Sorting student asccending by average mark.");
            Console.WriteLine(" 3.Display all the student.");
            Console.WriteLine(" 4.Search Student by Name");
            Console.WriteLine(" 5 Delete Student by student id");
            Console.WriteLine(" 6.Exit program.");
        }




        // input student
        public void InputStudent()
        {
            Student student = new Student();
            Console.WriteLine("Student id: ");
            student.Id = Convert.ToInt32(Console.ReadLine()); ;

            Console.WriteLine("Student name: ");
            student.Name = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(student.Name))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                student.Name = Console.ReadLine();
            }

            Console.WriteLine("Gender :");

            student.Gender = Convert.ToString(Console.ReadLine());
            if (string.IsNullOrEmpty(student.Name))
            {
                Console.WriteLine("Gender can't be empty! Input gender once more");
                student.Gender = Console.ReadLine();
            }

            Console.WriteLine("Age: ");
            student.Age = Convert.ToInt32(Console.ReadLine());

            
            /*Console.WriteLine("Date of Birth");
            student.DateOfBirth = Console.ReadLine();*/

            Console.WriteLine("Class: ");
            student.Clazz = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Mark1: ");
            student.Mark1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Mark2: ");
            student.Mark2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Mark3: ");
            student.Mark3 = Convert.ToDouble(Console.ReadLine());

            AverageMarkStudent(student);

            listStudents.Add(student);
        }

        public void AverageMarkStudent(Student student)
        {
            double averageMark = (student.Mark1 + student.Mark2 + student.Mark3) / 3;
            student.AverageMark = Math.Round(averageMark, 2, MidpointRounding.AwayFromZero);

        }


        // Display student 

        public void DisplayStudent(List<Student> listStudents)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} ",
                  "ID", "Name", "Gender", "Age", "Mark1", "Mark2", "Mark3", "Diem TB");
            // hien thi danh sach sinh vien
            if (listStudents != null && listStudents.Count > 0)
            {
                foreach (Student st in listStudents)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10}",
                                      st.Id, st.Name, st.Gender, st.Age, st.Mark1, st.Mark2, st.Mark3,
                                      st.AverageMark);
                }
            }
            Console.WriteLine();
        }

        public List<Student> getListS()
        {
            return listStudents;
        }
        public void findStudentName(string name)
        {
            // List<Student> studentS = new List<Student>();

            // bool isExist = listStudents.Find(name);

           
        }

        // Update student 
        public void UpdateStudent(int id)
        {
            Student st = FindStudentById(id);

            if (st != null)
            {
                Console.WriteLine("Student name: ");
                string name = Convert.ToString(Console.ReadLine());
                st.Name = name;
                /*if (name != null && name.Length > 0)
                {
                    st.Name = name;
                }*/
                Console.WriteLine("Gender :");
                string gender = Convert.ToString(Console.ReadLine());

                if (gender != null && gender.Length > 0)
                {
                    st.Gender = gender;
                }
                Console.WriteLine("Age: ");
                string newAge = Convert.ToString(Console.ReadLine());

                if (newAge != null && newAge.Length > 0)
                {
                    st.Age = Convert.ToInt32(newAge);
                }

                /*Console.WriteLine("Date of Birth");
                student.DateOfBirth = Console.ReadLine();*/

                Console.WriteLine("Class: ");
                string newClass = Convert.ToString(Console.ReadLine());
                if (newClass != null && newClass.Length > 0)
                {
                    st.Clazz = newClass;
                }

                Console.WriteLine("Mark1: ");
                string newMark1 = Convert.ToString(Console.ReadLine());
                
                
                if (newMark1 != null && newMark1.Length > 0)
                {
                    st.Mark1 = Convert.ToDouble(newMark1);
                }

                Console.WriteLine("Mark2: ");
                string newMark2 = Convert.ToString(Console.ReadLine());

                
                if (newMark2 != null && newMark2.Length > 0)
                {
                    st.Mark2 = Convert.ToDouble(newMark2);
                }


                Console.WriteLine("Mark3: ");
                string newMark3 = Convert.ToString(Console.ReadLine());

                
                if (newMark3 != null && newMark3.Length > 0)
                {
                    st.Mark3 = Convert.ToDouble(newMark3);
                }

            }

        }

        // Find student by ID
        public Student FindStudentById (int id )
        {
            Student studentId = null;

            if (listStudents != null && listStudents.Count > 0)
            {
                foreach (Student st in listStudents)
                {
                    if (st.Id == id)
                    {
                        studentId = st;
                    }
                }
            }

            return studentId;
        }

        public bool DeleteStudentById (int id)
        {
            Student studentId = FindStudentById(id);

            bool isDeleteSt = false;

            if (studentId != null )
            {
                isDeleteSt = listStudents.Remove(studentId);

            }

            return isDeleteSt;

        }
        
        public void SortByAverageMark()
        {

            listStudents.Sort(delegate (Student st1, Student st2) {
                return st1.AverageMark.CompareTo(st2.AverageMark);
            });


        }

    }
}
