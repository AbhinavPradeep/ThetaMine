using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Extra
{
    public class Languages: IEnumerable<Language>
    {
        public Languages()
        {
            Languageset = new List<Language>();
        }

        public Languages(IEnumerable<Language> seed)
        {
            this.Languageset = seed.ToList();
        }

        public Languages(List<Language> emailIDs)
        {
            this.Languageset = emailIDs;
        }
        public List<Language> Languageset { get; set; }

        public IEnumerator<Language> GetEnumerator()
        {
            return Languageset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Languageset.GetEnumerator();
        }

    }
}