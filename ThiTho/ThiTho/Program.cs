

namespace ThiTho
{
    public class Program
    {
        
        
        public static void Main(string[] args)
        {
            StudentFunction studentF = new StudentFunction();

            while (true)
            {
                Console.WriteLine(" 1.Input information(input details for a student).");
                Console.WriteLine(" 2.Sorting student asccending by average mark.");
                Console.WriteLine(" 3.Display all the student.");
                Console.WriteLine(" 4.Search Student by Name");
                Console.WriteLine(" 5 Delete Student by student id");
                Console.WriteLine(" 6.Exit program.");
                Console.Write("Enter your choice: ");
                int c = Convert.ToInt32(Console.ReadLine());

                switch(c)
                {
                    case 1:
                        Console.WriteLine("Enter student");
                        studentF.InputStudent();
                    break;

                    case 2:
                        Console.WriteLine(" 2.Sorting student asccending by average mark.");
                        
                        studentF.SortByAverageMark();
                        studentF.DisplayStudent(studentF.getListS());
                        
                        
                    break;

                    case 3:
                        Console.WriteLine(" 3.Display all the student.");
                        studentF.DisplayStudent(studentF.getListS());
                    break;

                
                    case 4:
                        Console.WriteLine(" 4. Find student by name.");
                        Console.WriteLine("\nEnter name: ");
                        string name = Convert.ToString(Console.ReadLine());
                        List<Student> searchResult ;
                        studentF.findStudentName(name);
                        
                   break;

                   case 5:
                        Console.WriteLine(" 5 Delete Student by student id");
                        Console.WriteLine("Enter id to delete ");

                        int id = Convert.ToInt32(Console.ReadLine());
                        studentF.DeleteStudentById(id);

                         
                        break;

                
                    default:
                        break;
                }
            }
        }

    }
}