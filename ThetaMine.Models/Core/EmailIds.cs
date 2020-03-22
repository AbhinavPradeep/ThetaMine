using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Core
{
    public class EmailIDs:IEnumerable<EmailID>
    {
        public EmailIDs()
        {
            emailIDset = new List<EmailID>();
        }
        public EmailIDs(List<EmailID> emailIDs)
        {
            this.emailIDset = emailIDs;
        }
        public List<EmailID> emailIDset { get; set; }

        public IEnumerator<EmailID> GetEnumerator()
        {
            return emailIDset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.emailIDset.GetEnumerator();
        }
    }
}