using System;

namespace HeistPartII
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank Bank)
        {
            Bank.VaultScore = Bank.VaultScore - SkillLevel;

            Console.WriteLine($"{Name} is cracking the vault system. Decreased vault security by {SkillLevel} points.");

            if (Bank.VaultScore <= 0)
            {
                Console.WriteLine("${Name} has disabled the vault.");
            }
            else
            {
                Console.WriteLine("Vault still intact.");
            }
        }
    }
}