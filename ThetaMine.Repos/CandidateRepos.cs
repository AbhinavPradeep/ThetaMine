using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using ThetaMine.Models.Core;

namespace ThetaMine.Repos
{
    public class CandidateRepos
    {
        private string ConnectionString { get; set; }
        public CandidateRepos(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        private IMongoCollection<Candidate> Initialize()
        {
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase("CandidateDB");
            var collection = database.GetCollection<Candidate>("Candidate");
            return collection;
        }

        public Candidate GetCandidate(string _id)
        {
            IMongoCollection<Candidate> collection = Initialize();
            var DbCandidate = collection.Find<Candidate>(x => x._id == _id).First();
            return DbCandidate;
        }
        public List<Candidate> GetAllCandidates()
        {
            IMongoCollection<Candidate> collection = Initialize();
            var DbCandidate = collection.Find(x => true);
            return DbCandidate.ToList();
        }

        public long DeleteCandidate(string _id)
        {
            IMongoCollection<Candidate> collection = Initialize();
            var result = collection.DeleteOne<Candidate>(x => x._id == _id);
            return result.DeletedCount;
        }

        public void AddCandidate(Candidate candidate)
        {
            IMongoCollection<Candidate> collection = Initialize();
            collection.InsertOne(candidate);
        }
        public void UpdateCandidate()
        {
            IMongoCollection<Candidate> collection = Initialize();
        }
    }
}