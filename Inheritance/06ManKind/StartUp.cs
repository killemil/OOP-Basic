
namespace _06ManKind
{
    using System;

    class StartUp
    {
        static void Main()
        {
            try
            {
                string[] studentTokens = Console.ReadLine().Trim().Split();
                string[] workerTokens = Console.ReadLine().Trim().Split();

                Student student = new Student(studentTokens[0], studentTokens[1], studentTokens[2]);
                Worker worker = new Worker(workerTokens[0], workerTokens[1], decimal.Parse(workerTokens[2]), int.Parse(workerTokens[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
