using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ThetaMine.Models.Location;

namespace ThetaMine.Models.Extra
{
    public class PrefferedJobLocations: IEnumerable<Address>
    {
        public PrefferedJobLocations()
        {
            PrefferedJobLocationset = new List<Address>();
        }

        public PrefferedJobLocations(IEnumerable<Address> seed)
        {
            this.PrefferedJobLocationset = seed.ToList();
        }

        public PrefferedJobLocations(List<Address> addresses)
        {
            this.PrefferedJobLocationset = addresses;
        }
        public List<Address> PrefferedJobLocationset { get; set; }

        public IEnumerator<Address> GetEnumerator()
        {
            return PrefferedJobLocationset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.PrefferedJobLocationset.GetEnumerator();
        }
    }
}