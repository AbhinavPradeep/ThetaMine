using System;
using System.Text;

namespace ThetaMine.Models.Core
{
    public class Candidate
    {
        public string _id;
        public Avatars avatars { get; set; }
        public EmailIDs emailIDs { get; set; }
        public PhoneNumbers phoneNumbers { get; set; }
        public SocialProfiles socialProfiles { get; set; }
        public Gender gender{get;set;}
        public Candidate()
        {
            _id = RandomString(5, false);
            emailIDs = new EmailIDs();
            avatars = new Avatars();
            phoneNumbers = new PhoneNumbers();
            socialProfiles = new SocialProfiles();
            gender = new Gender();
        }
        public Candidate(string id)
        {
            this._id = id;
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
    }

}