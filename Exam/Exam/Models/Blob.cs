using System;
namespace Exam.Models
{
    using Interfaces;
    public class Blob : IBlob
    {
        private string name;
        private int health;
        private int damage;
        private string attackType;
        private string behaviorType;

        public Blob(string name, int health, int damage, string attackType, string behaviorType)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.AttackType = attackType;
            this.BehaviorType = behaviorType;
           
        }
        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The damage of the blob cannot be negative");
                }
                this.damage = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The health of the blob cannot be negative");
                }
                this.health = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the blob cannot be null or empty");
                }
                this.name = value;
            }
        }
        public string AttackType
        {
            get { return this.attackType; }
            set { this.attackType = value; }
        }

        public string BehaviorType
        {
            get { return this.behaviorType; }
            set { this.behaviorType = value; }
        }
    }
}
