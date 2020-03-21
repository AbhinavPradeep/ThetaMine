using System;
using System.Collections.Generic;
namespace ThetaMine.Models.Core
{
    public class SocialProfiles
    {
        public SocialProfiles()
        {
            socialProfiles = new List<SocailProfile>();
        }
        public List<SocailProfile> socialProfiles { get; set; }
    }
}