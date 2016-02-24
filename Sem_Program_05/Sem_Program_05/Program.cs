using System;
using Sem_Program_05.Classes;

namespace Sem_Program_05
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseMethod();
            Console.WriteLine("Would you like to run the program again? If you do type yes\n");
            var readLine = Console.ReadLine();
            if (readLine != null && readLine.Equals("yes"))
            {
                ExerciseMethod();
            }

        }

        private static void ExerciseMethod()
        {
            //Instantiating objects
            Bottlestate state = new Bottlestate(15);
            Pesimist pesimist = new Pesimist();
            Optimist optimist = new Optimist();

            //Adding observers into bottlestate
            state.Add(pesimist);
            state.Add(optimist);

            Console.WriteLine("Current state: " + state.Amount);

            //Change bottlestate
            Console.WriteLine("\nEnter the number you want to change, please be below 15");
            var variable = Convert.ToInt32(Console.ReadLine());
            state.ChangeAmount(variable);
        }
    }
}
