using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week6_ClassTest.Models
{
    public class Novice
    {

        public int NoviceId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public long Age { get; set; }

        public virtual NoviceDetail NoviceDetail {get; set; }
          

    }
}