using System;
using System.Collections;
using System.Collections.Generic;
namespace ThetaMine.Models.Core
{
    public class PhoneNumbers : IEnumerable<PhoneNumber>
    {
        public PhoneNumbers()
        {
            phoneNumberset = new List<PhoneNumber>();
        }
        public PhoneNumbers(List<PhoneNumber> phoneNumbers)
        {
            this.phoneNumberset = phoneNumbers;
        }
        public List<PhoneNumber> phoneNumberset { get; set; }
        public IEnumerator<PhoneNumber> GetEnumerator()
        {
            return phoneNumberset.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.phoneNumberset.GetEnumerator();
        }
    }
}