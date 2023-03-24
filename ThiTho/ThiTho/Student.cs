using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTho
{
    public class Student
    {
        private long id;
        
        private String name;
        private string gender; // enum here
        private int age;
        private DateOnly dateOfBirth;
        private string clazz;
        private double mark1;
        private double mark2;
        private double mark3;


        private double averageMark;
        public Student()
        {

        }

        /*public Student(long id, string name, Gender gender, int age, DateOnly dateOfBirth, string clazz, float mark1, float mark2, float mark3)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.dateOfBirth = dateOfBirth;
            this.clazz = clazz;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }*/

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }

        public DateOnly DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                dateOfBirth = value;
            }
        }

        public String Clazz
        {
            get { return clazz; }
            set
            {
                clazz = value;
            }
        }

        public double Mark1
        {
            get { return mark1; }
            set
            {
                mark1 = value;
            }
        }

        public double Mark2
        {
            get { return mark2; }
            set
            {
                mark2 = value;
            }
        }

        public double Mark3
        {
            get { return mark3; }
            set
            {
                mark3 = value;
            }
        }

        public String Gender
        {
            get { return gender; }
            set
            {
                gender = value;
            }
        }

        public double AverageMark
        {
            get { return averageMark; }
            set
            {
                averageMark = value;
            }
        }
        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   gender == student.gender;
        }


   


    }
    enum Gender
    {
        Male,
        Female
    }
   
 
}
