using System;

namespace BUFFTEKS.Models
{
    public class TeamProject
    {
        public int TeamID {get; set;}
        public Team TheTeam {get;set;}
        public int ProjectID {get; set;}
         public Project TheProject {get;set;}
    }    
}
