using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Core
{
    public class SocialProfiles: IEnumerable<SocailProfile>
    {
        public SocialProfiles()
        {
            socialProfileset = new List<SocailProfile>();
        }
        public SocialProfiles(List<SocailProfile> socialProfiles)
        {
            this.socialProfileset = socialProfiles;
        }

        public SocialProfiles(IEnumerable<SocailProfile> socialProfiles)
        {
            this.socialProfileset = socialProfiles.ToList();
        }
        public List<SocailProfile> socialProfileset { get; set; }

        public IEnumerator<SocailProfile> GetEnumerator()
        {
            return socialProfileset.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.socialProfileset.GetEnumerator();
        }
    }
}