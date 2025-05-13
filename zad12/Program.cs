namespace zad12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // създаване на стек от символи и четене на кодираната дума
            List<char> codedWord = Console.ReadLine().ToCharArray().ToList();
            Stack<char> decodedWord = new Stack<char>();

            // брояч за напредналото премахване на символи
            int forwardRemoveCount = 0;

            // четене на кодираната дума и декодирането ѝ
            for (int i = 0; i < codedWord.Count; i++)
            {
                // ако символът е '<', премахни последния символ от стека
                if (codedWord[i] == '<')
                {
                    decodedWord.Pop();
                }
                // ако символът е '>', увеличаване на броя: символи за премахване отпред 
                else if (codedWord[i] == '>')
                {
                    forwardRemoveCount++;
                }
                // премахване на символи при необходимост
                else if (forwardRemoveCount > 0)
                {
                    forwardRemoveCount--;
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
