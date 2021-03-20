using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesDBGestionProject.Models
{
    public class Assignment
    {

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }
    }
}
