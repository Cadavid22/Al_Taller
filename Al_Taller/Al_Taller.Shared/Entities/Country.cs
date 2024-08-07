using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace Al_Taller.Shared.Entities
{
    public class Country
    {   
        public int Id {  get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "El campo (0) no es requerido.")]
        public string Name { get; set; } = null!;
    }
}
