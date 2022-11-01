using System;
using System.Threading.Tasks;
using System.Threading;

namespace AsynchronousRandomWords
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Word: ");
                RunAndOutput(Console.ReadLine());
            }
            async Task RunAndOutput(string word)
            {
                DateTime before = DateTime.Now;
                int count = await RandomlyRecreateAsync(word);
                DateTime after = DateTime.Now;
                TimeSpan time = after - before;
                Console.WriteLine($"{time.Hours}h {time.Minutes}m {time.Seconds}s");
                Console.WriteLine(count);
            }

            int RandomlyRecreate(string word)
            {
                Random random = new Random();
                    int count = 0;
                    string newWord;
                    do
                    {
                        newWord = "";
                        for (int i = 0; i < word.Length; i++)
                            newWord += (char) ('a' + random.Next(26));
                        count++;
                    } while (newWord != word);
                    return count;
            }

            Task<int> RandomlyRecreateAsync(string word)
            {
                return Task.Run(() => RandomlyRecreate(word));
            }
        }
    }
}
