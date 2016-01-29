using System;
namespace Exam.Core
{
    using Interfaces;
    using InputOutput;
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Models.Attacks;
    using Models.Behaviors;

    public class Engine : IEngine
    {
        private readonly IBlobFactory blobFactory;
        private readonly Data data;
        private readonly PutridFart putridFart;
        private readonly Blobplode blobplode;
        private readonly Aggressive aggressive;
        private readonly Inflated inflated;
        private readonly ConsoleReader reader;
        private readonly ConsoleWriter writer;
        
        public Engine(
           IBlobFactory blobFactory,
           Data data,
           PutridFart putridFart,
           Blobplode blobplode,
           Aggressive aggressive,
           Inflated inflated,
           ConsoleReader reader,
           ConsoleWriter writer)
        {
            this.blobFactory = blobFactory;
            this.data = data;
            this.putridFart = putridFart;
            this.blobplode = blobplode;
            this.aggressive = aggressive;
            this.inflated = inflated;
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            while (true)
            {
                string command = this.reader.ReadLine();
               
                if (command.Equals("drop"))
                {
                    break;
                }
                string[] input = command.Split();
                this.ExecuteCommands(input);
            }
        }
        public void ExecuteCommands(string[] commands)
        {
            string command = commands[0];
            switch (command)
            {
                case "create": CreateBlobCommand(
                   commands[1],
                   int.Parse(commands[2]),
                   int.Parse(commands[3]),
                   commands[4],
                   commands[5]
                 );break;
                case "pass": break;
                case "attack" : ProduceAttack(commands[1],commands[2]); break;
                case "status": ProduceStatus(this.data.Blobs); break;
                default: throw new NotSupportedException("The command you entered is invalid!");
            }
        }
        private void ProduceAttack(string attackerName ,string targetName)
        {
            int countTriggle = 0;

            var attacker = this.data.Blobs.First(a => a.Name == attackerName);
            var target = this.data.Blobs.First(t => t.Name == targetName);

            if (countTriggle < 1)
            {
                TriggleBehavior(attacker);
                TriggleBehavior(target);
                countTriggle++;
            }

            ImplementAttack(attacker);
            ImplementAttack(target);
            
            
            if (attacker.Health > target.Health)// && CheckIfIsAlive(target) == false)
            {
                Console.WriteLine("Blob {0}: 25 HP, {1} Damage",attacker.Name,attacker.Damage);
            }
            else if (target.Health > attacker.Health )//&& CheckIfIsAlive(attacker) == false)
            {
                Console.WriteLine("Blob {0}: 25 HP, {1} Damage", target.Name, target.Damage);
            }
        }
        //
        //private bool CheckIfIsAlive(IBlob blob)
        //{
        //    bool isAlive;
        //    if (blob.Health < 1 && blob.AttackType == "Blobplode" || blob.Health < 0 && blob.AttackType != "Blobplode")
        //    {
        //        Console.WriteLine("Blob {0} KILLED",blob.Name);
        //        isAlive = false;
        //    }
        //    isAlive = true;
        //}

        private void TriggleBehavior(IBlob blob)
        {
            if (blob.Health < blob.Health / 2)
            {
                ImplementBehavior(blob);
            }
        }

        private void ImplementBehavior(IBlob blob)
        {
            if (blob.BehaviorType == "Aggressive")
            {
                aggressive.ProduceBehavior((Blob)blob);
            }
            else if (blob.BehaviorType == "Inflated")
            {
                inflated.ProduceBehavior((Blob)blob);
            }
        }

        private void ImplementAttack(IBlob blob)
        {
            if (blob.AttackType == "Putrid Fart")
            {
                putridFart.ProduceAttackDamage((Blob)blob);
            }
            else if (blob.AttackType == "Blobplode")
            {
                blobplode.ProduceAttackDamage((Blob) blob);
            }
        }
        protected virtual void ProduceStatus(IEnumerable<IBlob> blobs)
        {
            foreach (var blob in blobs)
            {
                Console.WriteLine("Blob {0}: {1}HP, {2} Damage",blob.Name,blob.Health,blob.Damage);
            }
        }
        private void CreateBlobCommand(string name, int health, int damage, string attackType, string behaviorType)
        {
            IBlob blob = this.blobFactory.CreateBlob(name,health,damage,attackType,behaviorType);
            this.data.AddBlob(blob);
        }
    }
}
