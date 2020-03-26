using System;

namespace ThetaMine.Models.Work
{
    public class Career
    {
        public Companies companies{get;set;}
        public Projects projects{get;set;}
        public RolesAndResponsibilities responsibilities{get;set;}

        public Career()
        {
            companies = new Companies();
            projects = new Projects();
            responsibilities = new RolesAndResponsibilities();
        }
    }
}