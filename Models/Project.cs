using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesDBGestionProject.Models
{
    public class Project
    {
        [Key]
        public int projectID { get; set; }
        public String name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public ICollection<Assignment> assignments { get; set; } = new List<Assignment>();

    }
}
