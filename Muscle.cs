using System;

namespace HeistPartII
{
    public class Muscle : IRobber
    {
        public string Specialty { get; set; }
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public Muscle(string specialty, string name, int skillLevel, int percentageCut)
        {
            Specialty = specialty;
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
        }

        public void PerformSkill(Bank Bank)
        {
            Bank.SecurityGuardScore = Bank.SecurityGuardScore - SkillLevel;

            Console.WriteLine($"{Name} is checking on security. Decreased security by {SkillLevel} points.");

            if (Bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine("${Name} has disabled the security.");
            }
            else
            {
                Console.WriteLine("Security still intact.");
            }
        }
    }
}