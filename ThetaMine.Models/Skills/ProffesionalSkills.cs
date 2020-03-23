using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Skills
{
    public class ProffesionalSkills: IEnumerable<ProffesionalSkill>
    {
        public ProffesionalSkills()
        {
            ProffesionalSkillset = new List<ProffesionalSkill>();
        }

        public ProffesionalSkills(IEnumerable<ProffesionalSkill> seed)
        {
            this.ProffesionalSkillset = seed.ToList();
        }

        public ProffesionalSkills(List<ProffesionalSkill> emailIDs)
        {
            this.ProffesionalSkillset = emailIDs;
        }
        public List<ProffesionalSkill> ProffesionalSkillset { get; set; }

        public IEnumerator<ProffesionalSkill> GetEnumerator()
        {
            return ProffesionalSkillset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.ProffesionalSkillset.GetEnumerator();
        }

    }
}