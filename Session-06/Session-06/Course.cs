﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Course
    {
        //properties
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }
        //constructos
        public Course()
        {

        }
        public Course (Guid id)
        {
            ID = id;
        }
        public Course (Guid id,string code)
        {
            ID = id;
            Code = code;

        }
        public Courses (Guid id,string code, string subject)
        {
            ID = id;
            Code=code;
            Subject = subject;
        }
    }
}
