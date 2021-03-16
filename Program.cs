using System;
using System.Collections.Generic;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank FirstNational = new Bank();

            FirstNational.AlarmScore = 60;

            Hacker gary = new Hacker("Hacker", "Gary", 50, 15);
            Hacker larry = new Hacker("Hacker", "Larry", 65, 25);
            Muscle chad = new Muscle("Muscle", "Chad", 85, 10);
            Muscle brad = new Muscle("Muscle", "Brad", 45, 22);
            LockSpecialist jimmy = new LockSpecialist("LockSpecialist", "Jimmy", 68, 32);

            List<IRobber> rolodex = new List<IRobber>()
            {
                gary, larry, chad, brad, jimmy
            };

            gary.PerformSkill(FirstNational);

        }
    }
}
