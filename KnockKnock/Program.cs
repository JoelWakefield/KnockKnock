using System;
using System.Text.RegularExpressions;

namespace KnockKnock
{
    class Program
    {
        private static bool QnA(string question, string answer)
        {
            var pattern = @"[^a-zA-Z ]+";

            Console.WriteLine(question);

            var reply = Console.ReadLine();

            var rep = Regex.Replace(reply, pattern, "").ToLower();
            var ans = Regex.Replace(answer, pattern, "").ToLower();

            if (rep == ans)
                return true;
            else 
                return false;
        }

        static void Main(string[] args)
        {
            var failed = true;

            do
            {
                failed = !QnA("Knock knock!", "whos there");
                
                if (failed) 
                    Console.WriteLine("Invalid response - try again.");
            } while (failed);

            failed = true;

            do
            {
                failed = !QnA("Arch.", "arch who");

                if (failed) 
                    Console.WriteLine("Invalid response - try again.");
            } while (failed);
            
            Console.WriteLine("Gesundheit!");   

            Console.ReadLine();
        }
    }
}
