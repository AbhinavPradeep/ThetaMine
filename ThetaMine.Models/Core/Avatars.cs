using System;
using System.Collections.Generic;
namespace ThetaMine.Models.Core
{
    public class Avatars
    {
        public Avatars()
        {
            avatars = new List<Avatar>();
        }
        public List<Avatar> avatars { get; set; }
    }
}