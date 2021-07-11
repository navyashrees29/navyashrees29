using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvocationProgram
{
    class Program
    {
        static double Calculate(int x, double y) { return x + y; }
        void Update(int newNumber) { System.Console.WriteLine(newNumber); }
        void Delete(string key) { }
        void MethodOne() { }
        void MethodTwo(string obj) { }
        int MethodThree(int obj) { return obj; }
        bool MethodFour(string obj,string obj2) { return true; }
        static void FunctionsAsAnArguments(Action obj1, Action<string> obj2, Func<int, int> obj3, Func<string, string, bool> obj4,Func<int,double,double> obj5,Action<int> obj6)
        {
            //Invoke Delegate objects
            obj1.Invoke();
            obj2.Invoke("string data");
            int intValue = obj3.Invoke(5);
            bool boolValue = obj4.Invoke("string1", "string2");
            double doubleValue = obj5.Invoke(5, 10.5);
            obj6.Invoke(10);
            
            Console.WriteLine(intValue);
            Console.WriteLine(boolValue);
            Console.WriteLine(doubleValue);
        }
        static void Main(string[] args)
        {
            //Call FunctionAsAnArguments 
            Program program = new Program();
            
            Func<int, double, double> func1 = new Func<int, double, double>(Program.Calculate);
            Action<int> action1 = new Action<int>(program.Update);
            Action<string> action2 = new Action<string>(program.Delete);
            Action action3 = new Action(program.MethodOne);
            Action<string> action4 = new Action<string>(program.MethodTwo);
            Func<int, int> func2 = new Func<int, int>(program.MethodThree);
            Func<string, string, bool> func3 = new Func<string, string, bool>(program.MethodFour);

            Program.FunctionsAsAnArguments(action3, action4, func2, func3, func1, action1);
        }
    }
}
