using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesWebApi.Models
{
    public class Cancion
    {
        [Key]
        public string NombreCancion { get; set; }
        [Required(ErrorMessage = "El campo del nombre es requerido")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "El campo del nombre es requerido")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "El nombre tiene que tener entre 5 a 20 caracteres")]
        public string Letra { get; set; }
        [Url]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre tiene que tener entre 2 a 100 caracteres")]
        public string Link { get; set; }

    }
}
