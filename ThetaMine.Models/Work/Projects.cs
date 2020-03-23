using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Work
{
    public class Projects: IEnumerable<Project>
    {
        public Projects()
        {
            Projectset = new List<Project>();
        }

        public Projects(IEnumerable<Project> seed)
        {
            this.Projectset = seed.ToList();
        }

        public Projects(List<Project> emailIDs)
        {
            this.Projectset = emailIDs;
        }
        public List<Project> Projectset { get; set; }

        public IEnumerator<Project> GetEnumerator()
        {
            return Projectset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Projectset.GetEnumerator();
        }

    }
}