using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ThetaMine.API.Configuration;
using ThetaMine.Models.Core;
using ThetaMine.Repos;

namespace ThetaMine.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidateController : ControllerBase
    {
        private readonly IOptions<ThetaMineSettings> _settings;

        public CandidateController(IOptions<ThetaMineSettings> settings)
        {
            this._settings = settings;
        }

        [HttpGet]
        public JsonResult ListCandidates()
        {
            CandidateRepos candidateRepos = new CandidateRepos(_settings.Value.ConnectionString);
            var candidates = candidateRepos.GetAllCandidates();
            return new JsonResult(candidates);
        }
        [HttpGet("{candidateID}")]
        public Candidate GetCandidate(string candidateID)
        {
            CandidateRepos candidateRepos = new CandidateRepos(_settings.Value.ConnectionString);
            var candidate = candidateRepos.GetCandidate(candidateID);
            return candidate;
        }
        [HttpDelete("{candidateID}")]
        public long DeleteCandidate(string candidateID)
        {
            CandidateRepos candidateRepos = new CandidateRepos(_settings.Value.ConnectionString);
            var DeletedCount = candidateRepos.DeleteCandidate(candidateID);
            return DeletedCount;
        }
        [HttpPost]
        public ActionResult TestAddCandidate()
        {
            CandidateRepos candidateRepos = new CandidateRepos(_settings.Value.ConnectionString);
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
