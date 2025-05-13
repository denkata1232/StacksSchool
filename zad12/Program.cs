namespace zad12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> codedWord = Console.ReadLine().ToCharArray().ToList();
            Stack<char> decodedWord = new Stack<char>();
            int forwardRemoveCount = 0;
            for (int i = 0; i < codedWord.Count; i++)
            {
                if (codedWord[i] == '<')
                {
                    decodedWord.Pop();
                }
                else if(codedWord[i] == '>')
                {
                    forwardRemoveCount++;
                }
                else if(forwardRemoveCount > 0)
                {
                    forwardRemoveCount--;
                }
                else
                {
                    decodedWord.Push(codedWord[i]);
                }
            }
            do
            {
                Console.Write(decodedWord.Pop());
            } while (decodedWord.Count > 0);
        }
    }
}
