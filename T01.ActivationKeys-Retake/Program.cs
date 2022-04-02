using System;

namespace T01.ActivationKeys_Retake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] cmdInfo = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string action = cmdInfo[0];

                if (action == "Contains")
                {
                    string substringToCheck = cmdInfo[1];

                    if (key.Contains(substringToCheck))
                    {
                        Console.WriteLine($"{key} contains {substringToCheck}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string flipCase = cmdInfo[1];

                    int startIndex = int.Parse(cmdInfo[2]);
                    int endIndex = int.Parse(cmdInfo[3]);

                    key = FlipCase(key, startIndex, endIndex, flipCase);

                    Console.WriteLine(key);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(cmdInfo[1]);
                    int endIndex = int.Parse(cmdInfo[2]);

                    key = key.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(key);
                }
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
        
        /// <summary>
        ///  Flips the case of the given string to upper case or lower case, depending on the given command;
        /// </summary>
        public static string FlipCase(string str, int startIndex, int endIndex, string flipCase)
        {
            string replacement = str.Substring(startIndex, endIndex - startIndex);

            if (flipCase == "Upper")
            {
                replacement = replacement.ToUpper();
            }
            else if (flipCase == "Lower")
            {
                replacement = replacement.ToLower();
            }

            str = str.Remove(startIndex, endIndex - startIndex);
            str = str.Insert(startIndex, replacement);

            return str;
        }
    }
}
