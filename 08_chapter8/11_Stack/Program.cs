namespace _11_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("first in line");
            myStack.Push("second in line");
            myStack.Push("third in line");
            myStack.Push("last in line");

            Console.WriteLine($"Peek() returned:\n{myStack.Peek()}");

            Console.WriteLine(
            $"The first Pop() returned:\n{myStack.Pop()}");
            Console.WriteLine(
            $"The second Pop() returned:\n{myStack.Pop()}");

            Console.WriteLine($"Count before Clear():\n{myStack.Count}");
            myStack.Clear();
            Console.WriteLine($"Count after Clear():\n{myStack.Count}");
        }
    }
}
