using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleCrud.netCore.Models
{
    public class OfertaLaboral
    {


        [Key]
        public int id { get; set;}
        [Required(ErrorMessage ="El titulo es obligatorio")]
        [StringLength(60,ErrorMessage ="El {0} debe ser al menos {2} y maximo {1} caracteres",MinimumLength =3)]
        [Display(Name = "Título")]
        public string titulo { get; set;}


        [Required(ErrorMessage = "La descripcion es obligatorio")]
        [StringLength(60, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string descripcion { get; set; }


        [Required(ErrorMessage = "El nombre de la empresa es obligatoria")]
        [StringLength(40, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre de Empresa")]
        public string empresa { get; set; }


        [Required(ErrorMessage = "La fecha es obligatoria")]
        //[StringLength(40, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de publicacion")]
        public DateTime fechaPublicacion { get; set;}

        [Required(ErrorMessage = "El Lugar  es obligatorio papu")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Lugar ")]
        public string lugar { get; set; }






    }
}
