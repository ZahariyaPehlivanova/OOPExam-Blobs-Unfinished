namespace Exam.Interfaces
{
    public interface IBlob
    {
        string Name { get; }
        int Health { get; }
        int Damage { get; }
        string AttackType {get;}
        string BehaviorType { get; }
    }
}
