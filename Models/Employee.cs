using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccesDBGestionProject.Models
{
    public class Employee
    {
        [Key]
        public int employeID { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String phone { get; set; }
        public String email { get; set; }

        public int departementID { get; set; }
        public Departement departement { get; set; }

        public ICollection<Assignment> assignments { get; set; } = new List<Assignment>();
    }
}
