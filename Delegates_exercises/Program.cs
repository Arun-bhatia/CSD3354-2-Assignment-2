using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Arun bhatia(C0732127)
//Harjeet Singh(C0730468)
namespace Delegates_exercises
{
    class program
    {
        //public delegate void MyDelegate();

        public static void Main(String[] args)
        {
            //    MyDelegate myDelegate = Method1;
            //    myDelegate+=Method2;
            //    myDelegate(50);
            //}
            //public static void Method1(int num1)
            //{
            //    Console.WriteLine(num1 * 2);
            //}


            // public static void Method2(int x)//static methodno parameters
            //{
            //    Console.WriteLine("Method 2 executed");
            //    Console.WriteLine("You entered "+x);
            //    Console.ReadLine();
            //}

            //public static void Method3(int num2)
            //{
            //    Console.WriteLine(num2 * 10);
            //}
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
        }
        
    }
    public class DelegateExercises
    {
        public delegate int MyDelegate();
        void Method1()
        {
            Console.WriteLine("my delegate");
        }
        
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}

