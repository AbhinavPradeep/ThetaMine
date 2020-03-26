using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Schooling
{
    public class Internships: IEnumerable<Internship>
    {
        public Internships()
        {
            Internshipset = new List<Internship>();
        }

        public Internships(IEnumerable<Internship> seed)
        {
            this.Internshipset = seed.ToList();
        }

        public Internships(List<Internship> emailIDs)
        {
            this.Internshipset = emailIDs;
        }
        public List<Internship> Internshipset { get; set; }

        public IEnumerator<Internship> GetEnumerator()
        {
            return Internshipset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Internshipset.GetEnumerator();
        }

    }
}