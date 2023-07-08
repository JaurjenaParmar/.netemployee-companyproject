using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestList.Models
{
    public class department
    {
        public int id { get; set; }
        public string department_name { get; set; }
        public string isActive { get; set; }
        [NotMapped]
        public List<department> dept_list { get; set; }
    }
}