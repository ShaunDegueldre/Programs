using System;

namespace UsingOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "SHHHHHH";
            string sent = Whisper(sentence, out bool whisperWord);
            Console.WriteLine(sent);
            Console.WriteLine(whisperWord);

        }
        static string Whisper(string sentence, out bool whisperWord)
        {
            whisperWord = true;
            return sentence.ToLower();

        }
    }
}
