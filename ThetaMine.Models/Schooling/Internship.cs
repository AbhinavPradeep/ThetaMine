using System;
using ThetaMine.Models.Work;

namespace ThetaMine.Models.Schooling
{
    public class Internship
    {
        public Project project { get; set; }
        public bool IsCurrent { get; set; }
        public bool IsVerified;
    }
}