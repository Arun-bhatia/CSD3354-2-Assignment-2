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
        public delegate void MyDelegate(int value);

        public static void Main(String[] args)
        {
            MyDelegate myDelegate = Method2;
            myDelegate(50);
        }

         public static void Method2(int x)//static methodno parameters
        {
            Console.WriteLine("Method 2 executed");
            Console.WriteLine("You entered "+x);
            Console.ReadLine();
        } 
    }
    }

