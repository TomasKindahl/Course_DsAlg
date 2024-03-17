using System.Collections;

namespace diverse_tests_slask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < 5; i++)
            {
                int r = rand.Next(1, 100);
                q.Enqueue(r);
                Console.Write(r+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                int n = q.Dequeue();
                Console.Write(n+" ");
            }
            Console.WriteLine();
        }
    }
}
