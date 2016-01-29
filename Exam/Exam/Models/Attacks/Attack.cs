namespace Exam.Models
{
    using Interfaces;
    public abstract class Attack : IAttack
    {
        public abstract void ProduceAttackDamage(Blob blob);
    }
}
