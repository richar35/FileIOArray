using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOArray
{
    class Program
    {
        static void Main(string[] args)
        {

            string dataPath = @"Data\Students.txt";
            string[] students = new string[3];

            students[0] = "Sue, Mcwaters, 46";
            students[1] = "Bill McGaw, 67";
            students[2] = "Charlie, Velis, 22";

            WriteAllStudents(dataPath, students);
            

        }

        static void DisplayAllStudents(string[] students)
        {
            Console.WriteLine();
            Console.WriteLine("Student Info");
            Console.WriteLine();


            //
            //diplay table
            //

            Console.WriteLine(
                  "First Name".PadRight(15) +
                  "LastName".PadRight(15) +
                  "Age".PadRight(15)
                  );

            Console.WriteLine(
                 "----------".PadRight(15) +
                 "----------".PadRight(15) +
                 "----------".PadRight(15)
                 );



            foreach (string student in students)
            {
                string[] studentInfo = student.Split(',');

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                string age = studentInfo[2];

                

                //
                //diplay header
                //
               
                Console.WriteLine(
               firstName.PadRight(15) +
               lastName.PadRight(15) +
               age.PadRight(15)
               );


                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static string[] ReadAllStudents(string dataPath)
        {
            string[] students;

            students = File.ReadAllLines(dataPath);

            return students;

            
        }

        static void WriteAllStudents(string dataPath, string[] students)
        {
            File.WriteAllLines(dataPath, students);
        }
    }
}
