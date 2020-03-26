using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Schooling
{
    public class Subjects: IEnumerable<Subject>
    {
        public Subjects()
        {
            Subjectset = new List<Subject>();
        }

        public Subjects(IEnumerable<Subject> seed)
        {
            this.Subjectset = seed.ToList();
        }

        public Subjects(List<Subject> emailIDs)
        {
            this.Subjectset = emailIDs;
        }
        public List<Subject> Subjectset { get; set; }

        public IEnumerator<Subject> GetEnumerator()
        {
            return Subjectset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Subjectset.GetEnumerator();
        }

    }
}