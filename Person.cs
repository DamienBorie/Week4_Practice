using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Practice
{
    internal class Person
    {
        private string name;
        public Person(string name)
        {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name must not be blank or empty");
            this.name = name;
        }
        public string Name
        {
            get{return name;}
            set{name = value;}
        }
        public override string ToString()
        {
            return name;
        }
    }
}
