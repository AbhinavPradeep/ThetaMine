using System;
namespace ThetaMine.Models.Core
{
    public class EmailID
    {
        public EmailID(string UserName, string DomainName)
        {
            this.UserName = UserName;
            this.DomainName = DomainName;
        }
        public string UserName { get; set; }
        public string DomainName { get; set; }
        public string Email { get { return $"{UserName}@{DomainName}"; } }
        public bool IsPrimary { get; set; }

        public EmailID()
        {
            
        }
    }
}