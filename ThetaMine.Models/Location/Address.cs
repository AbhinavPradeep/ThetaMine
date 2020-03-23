using System;
namespace ThetaMine.Models.Location
{
    public class Address
    {
        public bool IsVerified{get;set;}
        public string Country{get;set;}
        public string State{get;set;}
        public string Street{get;set;}
        public int HouseNum{get;set;}
    }
}