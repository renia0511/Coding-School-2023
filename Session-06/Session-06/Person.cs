using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Session_06
{
    public class Person
    {
        //properties
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //constructors
        public Person()
        {

        }
        public Person (Guid id)
        {
            ID= id;
        }
        public Person (Guid id, string name)
        {
            ID = id;
            Name= name;
        }
        public Person (Guid id, string name , int name)
        {
            ID = id;
            Name = name;
            Age = Age;
        }
        // methods
        public void GetName()
        {

        }
        public SetName(string name)
        {

        }
    }
}
