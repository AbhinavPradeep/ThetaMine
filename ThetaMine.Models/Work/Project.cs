using System;
using ThetaMine.Models.Location;
using ThetaMine.Models.Skills;

namespace ThetaMine.Models.Work
{
    public class Project
    {
        public string ProjectName { get; set; }
        public int TenureinMonths { get; set; }
        public string ProjectRole { get; set; }
        public string ProjectDomain { get; set; }
        public Company CompanyClient { get; set; }
        public Address ProjectLocation { get; set; }
        public ProffesionalSkills Skills { get; set; }
        public string Description { get; set; }
        public string ProjectLink { get; set; }
        public int TeamSize { get; set; }
        public string Designation { get; set; }
        public RolesAndResponsibilities RolesAndResponsibilities { get; set; }
    }
}