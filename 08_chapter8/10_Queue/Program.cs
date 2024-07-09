namespace _10_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("first in line");
            myQueue.Enqueue("second in line");
            myQueue.Enqueue("third in line");
            myQueue.Enqueue("last in line");

            Console.WriteLine($"Peek() returned:\n{myQueue.Peek()}");

            Console.WriteLine(
            $"The first Dequeue() returned:\n{myQueue.Dequeue()}");
            Console.WriteLine(
            $"The second Dequeue() returned:\n{myQueue.Dequeue()}");

            Console.WriteLine($"Count before Clear():\n{myQueue.Count}");
            myQueue.Clear();
            Console.WriteLine($"Count after Clear():\n{myQueue.Count}");
        }
    }
}
