namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // създаване на стек от цели числа
            Stack<int> input = new Stack<int>(Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            // проверка за повтарящи се елементи
            bool hasRepeated = false;

            // проверка дали стекът има два повтарящи се елемента един след друг
            for (int i = 1; i < input.Count;)
            {
                if (input.Pop() == input.Peek())
                {
                    hasRepeated = true;
                    break;
                }
            }

            // отпечатване на съответното съобщение
            string message = hasRepeated ? "YES" : "NO";
            Console.WriteLine(message);
        }
    }
}
