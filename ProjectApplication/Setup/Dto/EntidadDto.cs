using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApplication.Setup.Dto
{
    public class EntidadDto
    {
        [Required]
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [StringLength(50)]
        public string RazonSocial { get; set; }

		public int Documento { get; set; }

		[Required(ErrorMessage = "El ID del Tipo de Documento es requerido.")]
        public int TipoEntidad { get; set; }
    }
}
