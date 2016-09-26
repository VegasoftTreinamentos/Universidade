using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade.Contoso.Dominio.Entidades
{
    public class Student : Person
    {
        [DataType(DataType.Date)]
        [Display(Name = "Data da Matrícula")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
