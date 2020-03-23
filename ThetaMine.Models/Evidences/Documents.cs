using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Evidences
{
    public class Documents: IEnumerable<Document>
    {
        public Documents()
        {
            documentset = new List<Document>();
        }

        public Documents(IEnumerable<Document> seed)
        {
            this.documentset = seed.ToList();
        }

        public Documents(List<Document> emailIDs)
        {
            this.documentset = emailIDs;
        }
        public List<Document> documentset { get; set; }

        public IEnumerator<Document> GetEnumerator()
        {
            return documentset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.documentset.GetEnumerator();
        }
    }
}