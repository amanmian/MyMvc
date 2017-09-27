using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week6_ClassTest.Models
{
    public class NoviceDetail
    {
       
        public int NoviceId { get; set; }

        
        public string CurrentAddress { get; set; }
        public string Stream { get; set; }
        public string FathersName { get; set; }
        public string PermanentAddress { get; set; }

        public virtual Novice Novice { get; set; }

    }
}