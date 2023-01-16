using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Professor

    {
        //properties
        public string Rank { get; set; }
        public Course[] Courses{get; set;}

        //constructors
        public Professor()
        {

        }
        public Professor (string rank)
        {
            Rank = rank;
        }
        public Professor(Courses[] courses,string rank)
        {
            Rank = rank;
            Courses = courses;

        }
      
    }
    public class Professor : Person
    {
        public int Grade { get; set; }

        public Student(string name) : base name{
            }
    public 

}
