using System;
namespace ThetaMine.Models.Core
{
    public class PhoneNumber
    {
        public string CountryCode { get; set; }
        public string Number { get; set; }
        public string phoneNumber { get { return $"{CountryCode}+{Number}"; } }
        public bool IsMain { get; set; }
    }
}