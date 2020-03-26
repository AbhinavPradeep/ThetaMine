using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThetaMine.Models.Schooling
{
    public class MarksCards: IEnumerable<MarksCard>
    {
        public MarksCards()
        {
            MarksCardset = new List<MarksCard>();
        }

        public MarksCards(IEnumerable<MarksCard> seed)
        {
            this.MarksCardset = seed.ToList();
        }

        public MarksCards(List<MarksCard> emailIDs)
        {
            this.MarksCardset = emailIDs;
        }
        public List<MarksCard> MarksCardset { get; set; }

        public IEnumerator<MarksCard> GetEnumerator()
        {
            return MarksCardset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.MarksCardset.GetEnumerator();
        }

    }
}