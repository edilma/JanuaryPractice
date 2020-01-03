using System;

namespace JanuaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a code to unscramble");
            string originalWord = Console.ReadLine();

            string result = MysteryFunc(originalWord);
            Console.WriteLine(result);
            
            Console.Read();
        }
        
        public static string MysteryFunc(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i=i+2)
            {
                char number = str[i + 1];
                int lenghtWord = Convert.ToInt32(number.ToString());
                
                string letters = "";
                for (int j = 0; j < lenghtWord; j++)
                {
                    //Console.WriteLine(letters);
                    letters = letters + str[i];
                }

                result = result + letters;

            }
            return result;
        }

    }
}
