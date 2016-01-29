namespace Exam.Models.Behaviors
{
    using Interfaces;
    public abstract class Behavior : IBehavior
    {
        public abstract void ProduceBehavior(Blob blob);
    }
}
