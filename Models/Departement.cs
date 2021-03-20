using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesDBGestionProject.Models
{
    public class Departement
    {

        [Key]
        public int departementID { get; set; }
        public String Description { get; set; }
        public String Ville { get; set; }

        public List<Employee> employees { get; set; }
    }
}
