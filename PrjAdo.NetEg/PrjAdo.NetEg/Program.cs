using System;

namespace PrjAdo.NetEg
{

    class Student:College
    {
        internal int id = 101;

        internal void DisplayStudent()
        {
            Console.WriteLine("CollegeName:{0} || StudentId:{0}",collegename,id);
        }
    }
   

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.DisplayStudent();

            Program program = new Program();
            //error
           // Console.WriteLine(program.collegename);
            
        }
    }
}
