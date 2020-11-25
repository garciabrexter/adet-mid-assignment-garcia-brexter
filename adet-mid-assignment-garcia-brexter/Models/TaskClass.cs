using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace adet_mid_assignment_garcia_brexter.Models
{
    public class TaskClass
    {
      
        [Key]

    

        public string taskName { get; set; } 


            
            public Nullable<DateTime> dateCreated { get; set; }

        
            public Nullable<DateTime> dateStarted { get; set; }

      
            public Nullable<DateTime> dateFinished { get; set; }

          
            public string totalNo_ofHours { get; set; }

            
        }
    }

