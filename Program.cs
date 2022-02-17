using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student s1 = new Student("Poul", "123123", 58);
            Student s2= new Student("Sebastian", "54545", 24);
            Student s3 = new Student("Nicolai", "99999",22);
            Student s4 = new Student("Arsen", "54545", 24);
            Student s5 = new Student("Sebastian", "6666", 24);
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            //Sorter students efter name

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }


            //Find alle studenter med Mobile == "54545"
            //Anvend funktionen mobileSearch (nederst)

            //Lav et predicate til at søge efter  Mobile == "54545



            Console.ReadLine();

            bool mobileSearch(Student s)
            {
                return s.Mobile == "54545";
            }

        }
    }
}
