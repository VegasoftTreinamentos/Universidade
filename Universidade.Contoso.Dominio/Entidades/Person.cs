using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Universidade.Contoso.Dominio.Entidades
{
    public abstract class Person
    {
        [Key]
        public int PersonID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Column("FirstName")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters.")]
        [Display(Name = "Nome")]
        public string FirstMidName { get; set; }

        [Display(Name = "Nome Completo")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
    }
}
