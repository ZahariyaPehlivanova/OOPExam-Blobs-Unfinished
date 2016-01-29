namespace Exam.Models.Behaviors
{
    public class Aggressive : Behavior
    {
        public override void ProduceBehavior(Blob blob)
        {
            var startedDamage = blob.Damage;
            blob.Damage *= blob.Damage;
            blob.Damage -= 5;
            if (blob.Damage < startedDamage)
            {
                blob.Damage = startedDamage;
            }
        }
    }
}
