using Puzzles.StringLib;

namespace Puzzles.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            // StringLib 

            var phrase = "one two three foure five";

            var reverseString = new ReverseString().GetReverseString(phrase);

            System.Console.WriteLine("original text :  {0} , Reverse Text: {1}", phrase, reverseString);
            System.Console.ReadLine();


           // var restul = new EncryptString().Encrypt(phrase);
        }
    }
}
