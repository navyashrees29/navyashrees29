using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo student1 = new StudentInfo();
            student1.setId("101");
            student1.setName("Abhi");
            student1.setMarks(25);

            System.Console.WriteLine("Student1 id is "+ student1.getId());
            System.Console.WriteLine("Student1 name is "+ student1.getName());
            System.Console.WriteLine("Student1 marks is "+ student1.getMarks());

            StudentInfo student2 = new StudentInfo();
            student2.setId("102");
            student2.setName("Arun");
            student2.setMarks(50);

            System.Console.WriteLine("Student2 id is "+ student2.getId());
            System.Console.WriteLine("Student2 name is "+ student2.getName());
            System.Console.WriteLine("Student2 marks is "+ student2.getMarks());

        }
    }
}
