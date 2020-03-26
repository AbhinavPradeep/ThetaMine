using System;
namespace ThetaMine.Models.Schooling
{
    public class MarksCard
    {
        public CertifiyingAuthority CertifiyingAuthority { get; set; }
        public string CertificateName { get; set; }
        public string CertificateID { get; set; }
        public Subjects Subjects { get; set; }
        public bool OverallPercentage { get; set; }
    }
}