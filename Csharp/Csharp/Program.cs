using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(); //First Ever Meet b/w Thread and Student DataType = TypeLoad
            Student student2 = new Student();
            Student student3 = new Student();

            OverloadedConstructors obj1 = new OverloadedConstructors("Tom", "6578-4567-98760-5678", "ADVPV00T");
            OverloadedConstructors obj2 = new OverloadedConstructors("Tom", "6578-4567-98760-5678", "ADVPV00T", "1234566");
            OverloadedConstructors obj3 = new OverloadedConstructors("Tom", "6578-4567-98760-5678", "ADVPV00T", "1234566", "info@infi.com");

            obj1
        }
    }
}
