using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDomain.Setup.Entities
{
    public class Entidad
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [StringLength(50)]

        public string RazonSocial { get; set; }

		public int Documento { get; set; }

		[Column("TipoEntidadID")]
        public int TipoEntidadId { get; set; }

    }
}
