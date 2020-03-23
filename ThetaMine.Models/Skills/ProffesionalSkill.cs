using System;
namespace ThetaMine.Models.Skills
{
    public class ProffesionalSkill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double SkillRating { get; set; }
        public bool IsVerified { get; set; }
        public int ExperienceInMonth { get; set; }
    }
}