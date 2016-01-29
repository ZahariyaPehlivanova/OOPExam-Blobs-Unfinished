using Exam.Core;
using Exam.InputOutput;
using Exam.Models;
using Exam.Models.Attacks;
using Exam.Models.Behaviors;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var blobFactory = new BlobFactory();
            var data = new Data();
            var putridFart = new PutridFart();
            var blobplode = new Blobplode();
            var aggressive = new Aggressive();
            var inflated = new Inflated();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();

            var engine = new Engine(blobFactory,data,putridFart,blobplode,aggressive,inflated,reader,writer);
            engine.Run();
        }
    }
}

