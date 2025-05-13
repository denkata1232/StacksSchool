namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> input = new Stack<int>(Console.ReadLine()
                .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            bool hasRepeated = false;
            for (int i = 1; i < input.Count;)
            {
                if (input.Pop()==input.Peek())
                {
                    hasRepeated = true;
                    break;
                }
            }
            string message = hasRepeated ? "YES" : "NO";
            Console.WriteLine(message);
        }
    }
}
