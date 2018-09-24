using System;

namespace BUFFTEKS.Models
{
    public class Client
    {
        //project list
        public string ProjectName {get; set;}
        //PK (like id)
        public int ClientID {get; set;}
        //first name
         public string FirstName {get; set;}
        //lastname
        public string LastName {get; set;}
        //phone
        public string Phone {get; set;}
        //email
        public string Email {get; set;}
        //company or organization
        public string Company {get; set;}
    }
}
