using System;

namespace ConsoleApp1
{
    class Program
    {

        static public void PlayBackgroundMusic1()
        {
            Console.Beep(1320, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 250); Console.Beep(1320, 125); Console.Beep(1188, 125); Console.Beep(1056, 250); Console.Beep(990, 250); Console.Beep(880, 500); Console.Beep(880, 250); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 750); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); System.Threading.Thread.Sleep(250); // Console.Beep(1188, 500); Console.Beep(1408, 250); Console.Beep(1760, 500); Console.Beep(1584, 250); Console.Beep(1408, 250); Console.Beep(1320, 750); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); System.Threading.Thread.Sleep(500);
        }
        static public void PlayBackgroundMusic2()
        {
            Console.Beep(1188, 500); Console.Beep(1408, 250); Console.Beep(1760, 500); Console.Beep(1584, 250); Console.Beep(1408, 250); Console.Beep(1320, 750); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); System.Threading.Thread.Sleep(500);
        }

        static void Main(string[] args)
        {
            Console.Title = "Math Match!";
            Console.WindowWidth = 50; Console.BufferWidth = 50;
            Console.WindowHeight = 30; Console.BufferHeight = 30;
            Console.ForegroundColor = ConsoleColor.Green;


            int score = 0;
            int answer;
            int correctAnswer;
            int num01;
            int num02;
            int num03;

            Random rnd = new Random();
            
            Console.WriteLine("Welcome to Math Match! Prepare your mind!");

            PlayBackgroundMusic1();

            // First question


            // Creates new numbers and defines correct answer
            num01 = rnd.Next(12);
            num02 = rnd.Next(12);
            num03 = rnd.Next(50);
            correctAnswer = num01 * num02 + num03;
           
            Console.WriteLine();
            Console.Beep();
            Console.WriteLine("First question: {0} x {1} + {2}", num01, num02, num03); // Prints questions with variables
            answer = Convert.ToInt32(Console.ReadLine()); // get anwser input
            if (answer == correctAnswer)
            {
                Console.WriteLine("Correct! +1");
                score = ++score; // Increments Score
                Console.WriteLine("Current score: " + score);
            }else
            {
                Console.WriteLine("Incorrect! :(");
            }

            // End of question

            // Second question

            num01 = rnd.Next(12);
            num02 = rnd.Next(12);
            num03 = rnd.Next(50);
            correctAnswer = num01 * num02 + num03;

            Console.WriteLine();
            Console.Beep();
            Console.WriteLine("Next question: {0} x {1} + {2}", num01, num02, num03);
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == correctAnswer)
            {
                Console.WriteLine("Correct! +1");
                score = ++score;
                Console.WriteLine("Current score: " + score);
            }
            else
            {
                Console.WriteLine("Incorrect! :(");
            }

            // End of question 

            // Third question

            num01 = rnd.Next(12);
            num02 = rnd.Next(12);
            num03 = rnd.Next(50);
            correctAnswer = num01 * num02 + num03;

            Console.WriteLine();
            Console.Beep();
            Console.WriteLine("Next question: {0} x {1} + {2}", num01, num02, num03);
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == correctAnswer)
            {
                Console.WriteLine("Correct! +1");
                score = ++score;
                Console.WriteLine("Current score: " + score);
            }
            else
            {
                Console.WriteLine("Incorrect! :(");
            }

            // End of question 

            // Fourth question

            num01 = rnd.Next(12);
            num02 = rnd.Next(12);
            num03 = rnd.Next(50);
            correctAnswer = num01 * num02 + num03;

            Console.WriteLine();
            Console.Beep();
            Console.WriteLine("Next question: {0} x {1} + {2}", num01, num02, num03);
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == correctAnswer)
            {
                Console.WriteLine("Correct! +1");
                score = ++score;
                Console.WriteLine("Current score: " + score);
            }
            else
            {
                Console.WriteLine("Incorrect! :(");
            }

            // End of question 

            // fifth question

            num01 = rnd.Next(12);
            num02 = rnd.Next(12);
            num03 = rnd.Next(50);
            correctAnswer = num01 * num02 + num03;

            Console.WriteLine();
            Console.Beep();
            Console.WriteLine("Next question: {0} x {1} + {2}", num01, num02, num03);
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == correctAnswer)
            {
                Console.WriteLine("Correct! +1");
                score = ++score;
                Console.WriteLine("Current score: " + score);
            }
            else
            {
                Console.WriteLine("Incorrect! :(");
            }

            // End of question 

            // Print out score
            Console.WriteLine();
            Console.WriteLine("You've reached the end! Final Score: {0} ", score);
            if (score == 5)
            {
                Console.WriteLine("Perfect!");
            }
            else if (score == 0)
            {
                Console.WriteLine("Better luck next time!");
            }
            else
            {
                Console.WriteLine("Nice Try!");
            }
            Console.Beep();
            System.Threading.Thread.Sleep(1000);
            PlayBackgroundMusic2();
            

            // Wait for key press to end
            Console.ReadKey();
        }
    }
}
