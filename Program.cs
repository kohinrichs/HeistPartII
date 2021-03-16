using System;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank FirstNational = new Bank();

            FirstNational.AlarmScore = 60;

            Hacker gary = new Hacker();

            gary.Name = "Gary";
            gary.SkillLevel = 50;
            gary.PerformSkill(FirstNational);

        }
    }
}
