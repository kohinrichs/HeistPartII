using System;

namespace HeistPartII
{
    public class Hacker : IRobber
    {
        public string Specialty { get; set; }
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public Hacker(string specialty, string name, int skillLevel, int percentageCut)
        {
            Specialty = specialty;
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
        }

        public void PerformSkill(Bank Bank)
        {
            Bank.AlarmScore = Bank.AlarmScore - SkillLevel;

            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by {SkillLevel} points.");

            if (Bank.AlarmScore <= 0)
            {
                Console.WriteLine("${Name} has disabled the alarm system.");
            }
            else
            {
                Console.WriteLine("Alarm system still intact.");
            }
        }


    }
}