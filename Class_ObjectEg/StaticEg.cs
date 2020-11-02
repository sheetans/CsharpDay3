using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectEg
{
    class Student
    {
        internal static string collegename;
        string name;
        string dept;
       
        internal Student (string name, string dept)
        {
            this.name = name;
            this.dept = dept;
        }

        internal void DisplayDetails()
        {
            Console.WriteLine("name:{0}||dept:{1}||Collegname:{2}", name, dept, collegename);
        }

        class StaticEg
        {
            static void Main()
            {
                //accessing static variable by class name
                Console.WriteLine(" Enter the CollegeName");
                Student.collegename = Console.ReadLine();

                string name, dept;
                Console.WriteLine(" Enter the no of Students");
                int no = Convert.ToInt32(Console.ReadLine());
                Student[] student = new Student[no];
                for(int i=0;i<student.Length;i++)
                {
                    Console.WriteLine(" Enter the Name and Dept");
                    name = Console.ReadLine();
                    dept = Console.ReadLine();
                    student[i] = new Student(name, dept);
                }

                for (int i=0;i<no;i++)
                {
                    student[i].DisplayDetails();
                }
                Console.Read();

            }
        }

    }
}
