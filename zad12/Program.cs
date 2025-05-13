namespace zad12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a stack of chars and read the coded word
            List<char> codedWord = Console.ReadLine().ToCharArray().ToList();
            Stack<char> decodedWord = new Stack<char>();
            // count the number of forward remove characters
            int forwardRemoveCount = 0;
            // read the coded word and decode it
            for (int i = 0; i < codedWord.Count; i++)
            {
                // if the character is a '<' remove the last character from the stack
                if (codedWord[i] == '<')
                {
                    decodedWord.Pop();
                }
                // if the character is a '>' add the last character to the stack
                else if(codedWord[i] == '>')
                {
                    forwardRemoveCount++;
                }
                else if(forwardRemoveCount > 0)
                {
                    forwardRemoveCount--;
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
