namespace Exam.InputOutput
{
    using System;
    using Interfaces;
    public class ConsoleWriter : IConsoleWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
