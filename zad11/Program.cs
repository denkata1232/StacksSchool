namespace zad11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // създаване на стек от символи
            char[] codedWord = Console.ReadLine().ToCharArray();
            Stack<char> decodedWord = new Stack<char>();

            // четене на кодираната дума и декодирането ѝ
            for (int i = 0; i < codedWord.Length; i++)
            {
                // ако символът е "'", премахни последните два символа от стека
                if (codedWord[i] == '\'')
                {
                    decodedWord.Pop();
                    decodedWord.Pop();
                }
                // във всички останали случаи добави символа в стека
                else
                {
                    decodedWord.Push(codedWord[i]);
                }
            }

            // отпечатване на декодираната дума
            do
            {
                Console.Write(decodedWord.Pop());
            } while (decodedWord.Count > 0);
        }
    }
}
