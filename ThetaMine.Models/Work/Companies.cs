using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Work
{
    public class Companies: IEnumerable<Company>
    {
        public Companies()
        {
            Companieset = new List<Company>();
        }

        public Companies(IEnumerable<Company> seed)
        {
            this.Companieset = seed.ToList();
        }

        public Companies(List<Company> emailIDs)
        {
            this.Companieset = emailIDs;
        }
        public List<Company> Companieset { get; set; }

        public IEnumerator<Company> GetEnumerator()
        {
            return Companieset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Companieset.GetEnumerator();
        }
    }
}