namespace zad11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] codedWord = Console.ReadLine().ToCharArray();
            Stack<char> decodedWord = new Stack<char>();
            for(int i = 0; i < codedWord.Length; i++)
            {
                if (codedWord[i] == '\'')
                {
                    decodedWord.Pop();
                    decodedWord.Pop();
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
