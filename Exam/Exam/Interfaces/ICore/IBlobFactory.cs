namespace Exam.Interfaces
{
    public interface IBlobFactory
    {
        IBlob CreateBlob(string name, int health, int damage, string attackType, string behaviorType);
    }
}
