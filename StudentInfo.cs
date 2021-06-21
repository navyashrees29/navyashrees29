using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class StudentInfo
    {
        private string id;
        private string name;
        private int marks;

        public string getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public int getMarks()
        {
            return this.marks;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setMarks(int marks)
        {
            this.marks = marks;
        }

    }
}
