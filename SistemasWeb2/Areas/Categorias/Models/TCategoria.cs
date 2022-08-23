using System.ComponentModel.DataAnnotations;

namespace SistemasWeb2.Areas.Categorias.Models
{
    public class TCategoria
    {

        public int ID_CATEGORIA { get; set; }

        [Required(ErrorMessage="El campo nombre es obligatorio.")]

        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo descripcion es obligatorio.")]

        public string Descripcion { get; set; }

        public Boolean Estado { get; set; } 
        //public ICollection<TCursos> Cursos { get; set; }
    }
}
