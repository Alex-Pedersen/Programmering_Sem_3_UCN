using System;
using Sem_Program_05.Classes;

namespace Sem_Program_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating objects
            Bottlestate state = new Bottlestate(15);
            Pesimist pesimist = new Pesimist();
            Optimist optimist = new Optimist();

            //Adding observers into bottlestate
            state.Add(pesimist);
            state.Add(optimist);

            //Change bottlestate
            state.ChangeAmount(10);

            Console.ReadLine();

        }
    }
}
