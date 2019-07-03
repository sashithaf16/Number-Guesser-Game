using System;

namespace ApplicationTraversy
{
    class Program
    {
        static void Main(string[] args)
        {
            getAppInfo();

            greetUser();

            while (true)
            {

                // int correctNumber = 7; this is a fixed number

                //to autogenerate a random num

                //Create random object

                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //guess nmber variable

                int guess = 0;


                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //Validation to make sure its a number

                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Not a number");
                        continue; //keep going
                    }



                    guess = Int32.Parse(input); //Int32.Parse used to get the user input as an integer

                    //Console.WriteLine(guess);

                    //mact the number

                    if (guess != correctNumber)
                    {
                        Console.WriteLine("Wrong");
                    }


                }
                Console.WriteLine("Correct");

                Console.WriteLine("Play again [Y or N]");
                string ans = Console.ReadLine().ToUpper(); //get the user inout irrespective or if the user inouts in upper or lower case
                if (ans == "Y")
                {
                    continue;
                }

                else if (ans == "N")
                {
                    return;
                }

                else
                {
                    Console.WriteLine("Invalid input");
                    return;
                }


            }








        }

         static void greetUser()
        {
            //prompt
            Console.WriteLine("Name ?");
            //User input
            string nameInput = Console.ReadLine();

            Console.WriteLine("Hello  " + nameInput); 
        }

        static void getAppInfo()
        {
            string app = "number guesser";
            string version = "1.0";

            //background color use Console.BackgroundColor
            //TextColor Use Console.ForegroundColor

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("{0} : for version {1}", app, version);
            Console.ResetColor();
        }
    }
}
