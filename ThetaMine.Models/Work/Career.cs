using System;

namespace ThetaMine.Models.Work
{
    public class Career
    {
        Companies companies{get;set;}
        Projects projects{get;set;}
        RolesAndResponsibilities responsibilities{get;set;}

        public Career()
        {
            companies = new Companies();
            projects = new Projects();
            responsibilities = new RolesAndResponsibilities();
        }
    }
}