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
    }
}
