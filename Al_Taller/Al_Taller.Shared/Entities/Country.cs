using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace Al_Taller.Shared.Entities
{
    public class Country
    {   
        public int Id {  get; set; }

        [Display(Name ="Pais")]
        [MaxLength(100, ErrorMessage ="El campo (0) no puede tener mas de (1) caracteres.")]
        [Required(ErrorMessage = "El campo (0) no es requerido.")]
        public string Name { get; set; } = null!;
    }
}
