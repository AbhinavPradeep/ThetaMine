using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Work
{
    public class RolesAndResponsibilities : IEnumerable<RoleAndResponsibility>
    {
        public RolesAndResponsibilities()
        {
            RolesAndResponsibilitieset = new List<RoleAndResponsibility>();
        }

        public RolesAndResponsibilities(IEnumerable<RoleAndResponsibility> seed)
        {
            this.RolesAndResponsibilitieset = seed.ToList();
        }

        public RolesAndResponsibilities(List<RoleAndResponsibility> emailIDs)
        {
            this.RolesAndResponsibilitieset = emailIDs;
        }
        public List<RoleAndResponsibility> RolesAndResponsibilitieset { get; set; }

        public IEnumerator<RoleAndResponsibility> GetEnumerator()
        {
            return RolesAndResponsibilitieset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.RolesAndResponsibilitieset.GetEnumerator();
        }

    }
}