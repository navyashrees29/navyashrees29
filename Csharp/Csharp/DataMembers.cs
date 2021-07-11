using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class DataMembers
    {
        int x;//Non Static Data Member

        static int y; //Static Data Member

        public DataMembers() { } //Non Static initializer/constructor

        static DataMembers() { } //Static initializer/constructor

        public void Test() { } //Non Static method

        public static void NewTest() { } //Static method
    }
}
