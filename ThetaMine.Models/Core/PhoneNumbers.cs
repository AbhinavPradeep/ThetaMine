using System;
using System.Collections.Generic;
namespace ThetaMine.Models.Core
{
    public class PhoneNumbers
    {
        public PhoneNumbers()
        {
            phoneNumbers = new List<PhoneNumber>();
        }
        public List <PhoneNumber> phoneNumbers {get;set;}
    }
}