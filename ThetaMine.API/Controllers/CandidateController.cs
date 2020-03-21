using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ThetaMine.Models.Core;
using ThetaMine.Repos;

namespace ThetaMine.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidateController : ControllerBase
    {
        [HttpGet]
        public JsonResult ListCandidates()
        {
            CandidateRepos candidateRepos = new CandidateRepos("mongodb+srv://loluser:lolpassword@clusterone-5rfg7.mongodb.net/test?retryWrites=true&w=majority");
            var candidates = candidateRepos.GetAllCandidates();
            return new JsonResult(candidates);
        }
        [HttpGet("{candidateID}")]
        public Candidate GetCandidate(string candidateID)
        {
            CandidateRepos candidateRepos = new CandidateRepos("mongodb+srv://loluser:lolpassword@clusterone-5rfg7.mongodb.net/test?retryWrites=true&w=majority");
            var candidate = candidateRepos.GetCandidate(candidateID);
            return candidate;
        }
        [HttpDelete("{candidateID}")]
        public long DeleteCandidate(string candidateID)
        {
            CandidateRepos candidateRepos = new CandidateRepos("mongodb+srv://loluser:lolpassword@clusterone-5rfg7.mongodb.net/test?retryWrites=true&w=majority");
            var DeletedCount = candidateRepos.DeleteCandidate(candidateID);
            return DeletedCount;
        }
        [HttpPost]
        public ActionResult TestAddCandidate()
        {
            CandidateRepos candidateRepos = new CandidateRepos("mongodb+srv://loluser:lolpassword@clusterone-5rfg7.mongodb.net/test?retryWrites=true&w=majority");
            EmailID email = new EmailID("abhinav.pradeep", "gmail.com");
            email.IsPrimary = true;
            Candidate candidate = new Candidate();
            EmailIDs emailIDs = new EmailIDs();
            EmailID email2 = new EmailID("abhinav.pradeep", "hotmail.com");
            email2.IsPrimary = false;
            emailIDs.emailIDset.Add(email);
            emailIDs.emailIDset.Add(email2);
            candidate.emailIDs = emailIDs;
            candidateRepos.AddCandidate(candidate);
            return Ok();
        }
    }
}
