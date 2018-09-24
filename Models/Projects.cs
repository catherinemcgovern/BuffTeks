using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace Buffteks.Models
{
    public class Projects
    {
        //PK 
        //name 
        //leader FK team lead*
        //required hours
        //client - FK client 
        //deadline
        public int ProjectID { get; set; }
        
        public string ProjectName { get; set; }
        public int RequiredHours { get; set; }
        public DateTime Deadline  { get; set; }

          public int ClientId { get; set; }  //this is the first part of setting up the client foreign key
          public Client Client { get; set; }  //this is the second part of setting up the client foreign key




    }
}