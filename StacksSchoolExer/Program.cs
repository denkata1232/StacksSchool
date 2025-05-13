namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a stack of integers
            Stack<int> input = new Stack<int>(Console.ReadLine()
                .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            // checker for repeated elements
            bool hasRepeated = false;
            // check if the stack has 2 repeated elements in a row
            for (int i = 1; i < input.Count;)
            {
                if (input.Pop()==input.Peek())
                {
                    hasRepeated = true;
                    break;
                }
            }
            // prints a respective message
            string message = hasRepeated ? "YES" : "NO";
            Console.WriteLine(message);
        }
    }
}
