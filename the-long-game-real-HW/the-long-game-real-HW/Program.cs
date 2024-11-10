using System;
using System.IO;

namespace the_long_game_real_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask for user's name
            Console.Write("Enter your name: ");
            string username = Console.ReadLine();
            int score = 0;
            //Console.WriteLine(username);

            //Check if there is already an old file
            string fileName = $"{username}.txt";
            if (File.Exists(fileName))
            {
                // Load old score if applicable
                string oldScoreText = File.ReadAllText(fileName);
                if (int.TryParse(oldScoreText, out int oldScore))
                {
                    score = oldScore;
                    Console.WriteLine($"Welcome back, {username}! Starting score: {score}");
                }
            }
            else
            {
                Console.WriteLine($"Hello {username}! Starting score: {score}");
            }

            Console.WriteLine("Press any key to increase score. Press Enter to stop the game.");


            //Game Loop
            while (true)
            {
                var keyInfo = Console.ReadKey(true);

                //End game if Enter is pressed
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    break;
                }

                score++;
                Console.WriteLine($"Score: {score}");
            }

            //Save the final score to a file
            File.WriteAllText(fileName, score.ToString());
            Console.WriteLine($"\nGame Over! Final score saved as {score} in {fileName}");

            
        }
    }
}
