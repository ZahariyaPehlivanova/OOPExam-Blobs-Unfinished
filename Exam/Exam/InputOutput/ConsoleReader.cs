namespace Exam.InputOutput
{
    using System;
    using Interfaces;
    public class ConsoleReader : IConsoleReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();
            return input;
        }
    }
}
