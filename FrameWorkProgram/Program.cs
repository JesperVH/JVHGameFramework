using System;

namespace FrameWorkProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            FrameworkWorker worker = new FrameworkWorker();
            worker.Worker();
            Console.ReadKey();
        }
    }
}
