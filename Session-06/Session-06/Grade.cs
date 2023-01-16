using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Grade
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID {  get; set; }
        public int Grade { get; set; }

        public Grade () {
        }
        public Grade (Guid id)
        {
            ID = id;

        }
        public Grade (Guid id,Guid studentid)
        {
            ID = id;
            StudentID = studentid;
        }
        public Grade(Guid id, Guid studentid, Guid courseid)
        {
            ID = id;
            StudentID = studentid;
            CourseID = courseid;

        }
        public Grade(Guid id, Guid studentid, Guid courseid, int grade)
        {
            ID = id;
            StudentID = studentid;  
            CourseID = courseid;
            Grade = grade;
        }
    }
}
