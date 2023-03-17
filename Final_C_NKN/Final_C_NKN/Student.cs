using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Final_C_NKN
{
    public class Student : IStudent
    {
        private int studId = 1;
        private string studName;
        private int studAge;
        private string studGender;
        private string studClass;
        private float studAvgMark;

        // c)
        private float[] MarkList = new float[3];

        public Student()
        {

        }

        public Student(int id, string name, int age, string gender, string clazz)
        {
            this.studId = id;
            this.studName = name;
            this.studAge = age;
            this.studGender = gender;
            this.studClass = clazz;
            
        }

        public int StudId
        {
            get
            {
                return studId;
            }
            set
            {
                studId = value;
            }
        }

        public string StudName
        {
            get { return studName; }
            set
            {

                studName = value;

            }
        }

        public int StudAge
        {
            get { return studAge; }
            set
            {
                while (studAge < 0 && studAge > 100)
                {

                }
                studAge = value;
            }
        }


        public string StudGender
        {
            get { return studGender; }
            set
            {
                studGender = value;
            }
        }

        public string StudClass
        {
            get { return studClass; }
            set { studClass = value; }
        }

        public float StudAvgMark
        {
            get { return studAvgMark; }
            private set
            { studAvgMark = value; }
        }

        public float this[int index]
        {
            get { return MarkList[index]; }
            set { MarkList[index] = value; }
        }


        public void CalAvg()
        {
            float sum = 0;
            foreach (int mark in MarkList)
            {
                sum += mark;
            }
            StudAvgMark = sum / MarkList.Length;
        }


        // B) void print
        public void Print()
        {
            Console.WriteLine($" Name: {studName} - Gender: {studGender} - Age: {studAge} - Class: {studClass} - AvgMark : {studAvgMark} ");
        }


        public override string ToString()
        {
            return "Student: " + studId + "\n " +
            "Name: " + studName + "\n " +
            "Gender: " + studGender + "\n " +
            "Age: " + studAge + "\n " +
            "Class: " + studClass + "\n " +
            "AvgMark : " + studAvgMark;
        }


    }

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
}
