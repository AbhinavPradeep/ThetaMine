using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Core
{
    public class Avatars: IEnumerable<Avatar>
    {
        public Avatars()
        {
            avatarset = new List<Avatar>();
        }
        public Avatars(List<Avatar> avatars)
        {
            this.avatarset = avatars;
        }

        public Avatars(IEnumerable<Avatar> seed)
        {
            this.avatarset = seed.ToList();    
        }
        public List<Avatar> avatarset { get; set; }

        public IEnumerator<Avatar> GetEnumerator()
        {
            return avatarset.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.avatarset.GetEnumerator();
        }
    }
}