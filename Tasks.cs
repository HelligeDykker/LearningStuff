namespace hell
{
    public class Excercise2
    {
        //static void Main(string[] args)
        public void Objective1()
        {
            Console.WriteLine("enter a number");
            var input = Convert.ToInt32(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < input; i++)
            {
                if (i % 2 == 0)
                    count++;
            }
            Console.WriteLine($"{input} can be divided " + count + " times");
        }


        public void Objective2()
        {
            var count = 0;
            while (true)
            {
                Console.WriteLine("Enter 0 or Ok to terminate ");
                var input = Console.ReadLine();


                if (input.ToLower() != "ok" && input != "0")
                {
                    count++;
                    Console.WriteLine("user has typed " + count + " times");
                    continue;

                }
                break;

                //    var sum = 0;
                //    while (true)
                //    {
                //        Console.Write("Enter a number (or 'ok' to exit): ");
                //        var input = Console.ReadLine();

                //        if (input.ToLower() == "ok")
                //            break;

                //        sum += Convert.ToInt32(input);
                //    }
                //    Console.WriteLine("Sum of all numbers is: " + sum);

                //} 





            }

        }

        public void Objective3()
        {
            Console.WriteLine("Please Enter a number above 0");
            int inputvalue;
            var input = int.TryParse(Console.ReadLine(), out inputvalue) ? inputvalue : 0;
            if (input <= 0)
            {
                Console.WriteLine("Not a number Or cannot divide by 0");
            }
            var sum = 1;
            for (int i = 1; i <= input; i++)
                sum *= i;
            Console.WriteLine("{0}! = {1}", input, sum);

        }

        public void Objective4()
        {
            var diceroll = new Random();
            var number = diceroll.Next(1, 10);
            var wincon = false;
            var health = 4;
            while (health > 0 && wincon == false)
            {
                Console.WriteLine($"guess the number, you have {health} attempts");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == number)
                {
                    wincon = true;                                 
                }
                else 
                {
                    health--;
                }
            }
            if (wincon == true && health > 0) 
            {
                Console.WriteLine("you win");
            }                 
            else 
            {
                Console.WriteLine("You Lose" + '\n'+"all your mortal possesions are now mine!" + '\n' + "next time read the fine print");
            }

        }

        public void Objective5()
        {
            Console.Write("Enter commoa separated numbers: ");
            var input =  Console.ReadLine();

            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);
            Console.WriteLine(max);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            
         

          

          // Console.WriteLine("Max is " + max);

        }



    }
}




