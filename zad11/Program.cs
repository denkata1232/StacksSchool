namespace zad11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a stack of chars
            char[] codedWord = Console.ReadLine().ToCharArray();
            Stack<char> decodedWord = new Stack<char>();
            // read the coded word and decode it
            for (int i = 0; i < codedWord.Length; i++)
            {
                // if the character is a "'" remove the last 2 characters from the stack
                if (codedWord[i] == '\'')
                {
                    decodedWord.Pop();
                    decodedWord.Pop();
                }
                // in all other cases push the character to the stack
                else
                {
                    decodedWord.Push(codedWord[i]);
                }
            }
            // print the decoded word
            do
            {
                Console.Write(decodedWord.Pop());
            } while (decodedWord.Count > 0);
        }
    }
}
