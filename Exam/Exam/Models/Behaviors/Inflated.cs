namespace Exam.Models.Behaviors
{
    public class Inflated : Behavior
    {
        public override void ProduceBehavior(Blob blob)
        {
            blob.Health += 50;
            blob.Health -= 5;
        }
    }
}
