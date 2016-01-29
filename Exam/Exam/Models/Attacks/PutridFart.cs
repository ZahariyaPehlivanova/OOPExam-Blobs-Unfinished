namespace Exam.Models
{
    public class PutridFart : Attack
    {
        public override void ProduceAttackDamage(Blob blob)
        {
            blob.Damage = blob.Damage * 2;
            blob.Damage -= 5;
            if (blob.Health < blob.Health)
            {
                blob.Health = 0;
            }
        }
    }
}