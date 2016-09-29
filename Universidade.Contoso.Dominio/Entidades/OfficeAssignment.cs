using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade.Contoso.Dominio.Entidades
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]
        public int PersonID { get; set; }
        [StringLength(50)]
        [Display(Name = "Sala de aula")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}
