using System;
using System.Text;

namespace ThetaMine.Models.Core
{
    public class Candidate
    {

        
        public Avatars avatars { get; set; }
        public EmailIDs emailIDs { get; set; }
        public string _id;
        public PhoneNumbers phoneNumbers { get; set; }
        public SocialProfiles socialProfiles { get; set; }

        public Candidate()
        {
            _id = RandomString(5,false);
            emailIDs = new EmailIDs();
            phoneNumbers = new PhoneNumbers();
            socialProfiles = new SocialProfiles();
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
        // public EmailID Get_ID()
        // {
        //     foreach (EmailID email in emailIDs)
        //     {
        //         if(email.IsPrimary == true)
        //             return email;
        //     }
        //     return null;
        // }
    }
   
}