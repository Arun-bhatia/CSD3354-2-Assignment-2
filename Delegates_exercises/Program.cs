using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Arun bhatia(C0732127)
//Harjeet Singh(C0730468)
namespace Delegates_exercises
{
    class DelegateExercises
    {
        public delegate void MyDelegate();

        public static void Main(String[] args)
        {
            MyDelegate myDelegate = Method1;
            myDelegate();
        }

         public static void Method1()//static methodno parameters
        {
            Console.WriteLine("Method1 executed");
            //Console.WriteLine("You entered "+x);
            Console.ReadLine();
        } 
    }
    }

