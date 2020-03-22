using System;
using System.Collections;
using System.Collections.Generic;
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