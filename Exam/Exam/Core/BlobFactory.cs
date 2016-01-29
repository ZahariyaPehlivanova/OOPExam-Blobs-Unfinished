namespace Exam.Core
{
    using Models;
    using Interfaces;
    public class BlobFactory : IBlobFactory
    {
        public IBlob CreateBlob(string name, int health, int damage, string attackType, string behaviorType)
        {
            return new Blob(name, health, damage, attackType, behaviorType);
        }
    }
}
