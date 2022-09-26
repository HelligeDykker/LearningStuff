using hell;

namespace Hell
{
    class Oppgave

    {
        static void Main(string[] args)
        {
            Excercise2 task = new Excercise2();
            Console.WriteLine("Please Enter one of these numbers: 1 2 3 4 5");
            int inputvalue;
            var input = int.TryParse(Console.ReadLine(), out inputvalue) ? inputvalue : 0;
            
            

            switch (input)
            {
                    case 1: task.Objective1(); break;
                    case 2: task.Objective2(); break;
                    case 3: task.Objective3(); break;
                    case 4: task.Objective4(); break;
                    case 5: task.Objective5(); break;

                default:
                    {
                        Console.WriteLine("Wrong number");
                        break;
                    }

            }

            // task.Objective1();
            // task.Objective2();
            //task.Objective3();
            // task.Objective4();
            //task.Objective5();
        }
    }
}
