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
        public static void Main(String[] args)
        {
            DelegateExercises delegatesExercises = new DelegateExercises();
            delegatesExercises.Method3();
            Console.ReadLine();

        }
    }
        public class DelegateExercises
        {
            public delegate int Mydelegate(int value);
            int Method1(int intmethod1)
            {
                return intmethod1 * 4;
            }

            int Method2(int intmethod1)
            {
                return intmethod1 * 20;
            }

            public void Method4(Mydelegate myDelegate)
            {
                for(int i=1;i<=5;i++)
            {
                Console.WriteLine(myDelegate(i)+" ");
            }
        }

            public void Method3()
            {
                Mydelegate myDelegate = new Mydelegate(Method1);
                Method4(myDelegate);
                myDelegate = new Mydelegate(Method2);
                Method4(myDelegate);
            }
        }
    }

    



