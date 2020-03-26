using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ThetaMine.API.Configuration;
using ThetaMine.Models.Core;
using ThetaMine.Models.Location;
using ThetaMine.Models.Skills;
using ThetaMine.Models.Work;
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
        public ActionResult AddCandidate([FromBody]Candidate candidate)
        {
            CandidateRepos candidateRepos = new CandidateRepos(_settings.Value.ConnectionString);
            candidateRepos.AddCandidate(candidate);
            return Ok(candidate._id);
        }
        // public ActionResult AddCandidate()
        // {
        //     CandidateRepos candidateRepos = new CandidateRepos(_settings.Value.ConnectionString);
        //     Candidate candidate = new Candidate();
        //     Company company = new Company();
        //     Address address = new Address();
        //     ProffesionalSkill proffesionalSkill = new ProffesionalSkill();
        //     ProffesionalSkills proffesionalSkills = new ProffesionalSkills();
        //     Career career = new Career();
        //     Companies companies =new Companies();
        //     Project project = new Project();
        //     RoleAndResponsibility responsibility = new RoleAndResponsibility();
        //     RolesAndResponsibilities responsibilities = new RolesAndResponsibilities();
        //     company.Name = "Youi";
        //     address.Country = "Australia";
        //     address.State = "QLD";
        //     address.Street = "Nyes Crescent";
        //     address.HouseNum = 42;
        //     company.Location = address;
        //     proffesionalSkill.Name = "Coding";
        //     proffesionalSkill.SkillRating = 5.5;
        //     proffesionalSkill.ExperienceInMonth = 60;
        //     proffesionalSkill.Description="asdasdasdasdasdasdasdadasdasd";
        //     companies.Companieset.Add(company);
        //     proffesionalSkills.ProffesionalSkillset.Add(proffesionalSkill);
        //     project.Skills = proffesionalSkills;
        //     project.RolesAndResponsibilities = responsibilities;
        //     career.projects = ;
        //     career.responsibilities = ;
        //     career.companies = companies;
        //     return Ok(candidate._id);
        // }
    }
}
