using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_C_NKN
{
    public class StudentFunction
    {
        private Dictionary<int, Student> ht = null;

        public StudentFunction()
        {
            ht = new Dictionary<int, Student>();
        }

        public void InsertNewStudent()
        {
            Student st = new Student();
            Console.WriteLine("Input your ID");
            st.StudId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input student name: ");
            while (string.IsNullOrEmpty(st.StudName))
            {
                st.StudName = Convert.ToString(Console.ReadLine());
                var a = st.StudName;
                if (string.IsNullOrEmpty(a))
                {
                    Console.WriteLine("Invalid Input. Try again...");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Input student age: ");
            while (true)
            {
                st.StudAge = Convert.ToInt32(Console.ReadLine());
                if (st.StudAge > 0 && st.StudAge <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Number, please input again...");
                }
            }

            Console.WriteLine("Input gender: M = Male - F = Female - U = Unknown");
            while (string.IsNullOrEmpty(st.StudGender))
            {
                st.StudGender = Convert.ToString(Console.ReadLine().ToUpper());
                var g = st.StudGender;
                Gender genderEnum;
                if (string.IsNullOrEmpty(g))
                {
                    Console.WriteLine("Invalid Input. Try again...");
                }
                else if (st.StudGender.Equals("M"))
                {
                    genderEnum = Gender.Male;
                    st.StudGender = genderEnum.ToString();
                    Console.WriteLine(st.StudGender);
                    break;
                }
                else if (st.StudGender.Equals("F"))
                {
                    genderEnum = Gender.Female;
                    st.StudGender = genderEnum.ToString();
                    Console.WriteLine(st.StudGender);
                    break;
                }
                else
                {
                    genderEnum = Gender.Unknown;
                    st.StudGender = genderEnum.ToString();
                    Console.WriteLine(st.StudGender);
                    break;
                }


            }

            Console.Write("Input student class: ");
            while (string.IsNullOrEmpty(st.StudClass))
            {
                st.StudClass = Convert.ToString(Console.ReadLine());
                var a = st.StudClass;
                if (string.IsNullOrEmpty(a))
                {
                    Console.WriteLine("Invalid Input. Try again...");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Input student mark:");
            /*st.markLists[0] = Convert.ToInt32(Console.ReadLine());*/

            float[] markList = new float[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Mark {i + 1}: ");
                if (!float.TryParse(Console.ReadLine(), out markList[i]))
                {
                    Console.WriteLine($"Invalid input for Mark {i + 1}! Please enter an integer.");
                    return;
                }
            }

            Student nStudent = new Student(st.StudId, st.StudName, st.StudAge, st.StudGender, st.StudClass);
            for (int i = 0; i < 3; i++)
            {
                nStudent[i] = markList[i];
            }


            Console.WriteLine();
            ht.Add(st.StudId, st);
        }

        // indexers
        public void CalculateAverageMark()
        {

            foreach (KeyValuePair<int, Student> entry in ht)
            {
                Student student = (Student)entry.Value;
                student.CalAvg();
                student.Print();
            }
        }


        public void PrintAll()
        {
            foreach (KeyValuePair<int, Student> de in ht)
            {
                IStudent student = (IStudent)de.Value;
                student.Print();
                // Console.WriteLine("Key: {0}, Value\n: {1}", de.Key, de.Value);
            }
        }

        
        public Dictionary<int, Student> getList()
        {
            return ht;
        }

        public void Print(Dictionary<int, Student> myList)
        {
           /* IDictionaryEnumerator myEnumerator = myList.GetEnumerator();
            Console.WriteLine("\t-KEY-\t-VALUE");
            while (myEnumerator.MoveNext())
                Console.WriteLine("\t{0}:\t\n{1}", myEnumerator.Key, myEnumerator.Value);
            
            Console.WriteLine();*/

            foreach (KeyValuePair<int, Student> de in ht)
            {
                Console.WriteLine("Key: {0}, Value\n: {1}", de.Key, de.Value);
            }
        }

        /*public void Print()
        {
            throw new NotImplementedException();
        }*/


        // Find by id
        /* public Dictionary<int, Student> FindByID(int id)
         {

             return keys;
         }*/
        // find by id

        public void GetValues(int id)
        {
            if (ht.ContainsKey(id))
            {
                foreach (KeyValuePair<int, Student> de in ht)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
                }
            }
        }

        // find by class
       

        public List<KeyValuePair<int, Student>> findByName(string name)
        {
            List<KeyValuePair<int, Student>> listS = ht.ToList();

            var p = listS.FindAll
                      (
                           (a) =>
                           {
                               Console.WriteLine(a.Value);
                               return a.Value.StudName.Contains(name);
                           }
                      );

            return p;
        }

        public List<KeyValuePair<int, Student>> findByClass(string className)
        {
            List<KeyValuePair<int, Student>> listS = ht.ToList();

            var p = listS.FindAll
                      (
                           (a) =>
                           {
                               Console.WriteLine(a.Value);
                               return a.Value.StudClass.Contains(className);
                           }
                      );

            return p;
        }

        
        public void Display()
        {
            
                Console.WriteLine(" 1.Input Key to finding value.");
                Console.WriteLine(" 2.Input Name to finding value.");
                Console.WriteLine(" 3.Input Class to finding value.");
                int c = Convert.ToInt32(Console.ReadLine());
                switch(c)
                {
                    case 1:
                        Console.WriteLine(" 1.Input Key to finding value.");
                        int id = Convert.ToInt32(Console.ReadLine());
                        GetValues(id);
                        break;
                    case 2:
                        Console.WriteLine(" 2.Input Name to finding value.");
                        string a = Convert.ToString(Console.ReadLine());
                        findByName(a);
                        break;
                    case 3:
                        Console.WriteLine(" 3.Input Class to finding value.");
                        string d = Convert.ToString(Console.ReadLine());
                        findByClass(d);
                        break;
                    default:
                        break;
                }
        }
    }
}
