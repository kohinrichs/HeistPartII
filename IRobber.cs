namespace HeistPartII
{
    public interface IRobber
    {
        string Specialty { get; set; }
        string Name { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }
        void PerformSkill(Bank Bank);



    }
}