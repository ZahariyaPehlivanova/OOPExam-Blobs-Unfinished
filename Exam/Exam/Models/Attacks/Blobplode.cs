namespace Exam.Models.Attacks
{
    public class Blobplode : Attack
    {
        public override void ProduceAttackDamage(Blob blob)
        {
            blob.Health /= 2;
            blob.Damage *= blob.Damage;
            if (blob.Health < 1)
            {
                blob.Health = 1;
            }
        }
    }
}
