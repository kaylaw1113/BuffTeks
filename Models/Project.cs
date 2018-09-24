using System;

namespace BUFFTEKS.Models
{
   public class Project
   {
       //pk
       public int ProjectID {get; set;}
       //name
       public string ProjectName {get; set;}
       //leader= fk team leader
       public Team TeamID {get; set;}
       //hours required
       public int HoursWorked {get;set;}
       //client = fk 
       public Client ClientID {get;set;}
       //deadline - DateTime

   } 
}
