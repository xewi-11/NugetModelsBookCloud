using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetModelsBookCloud.Models
{
    [Table("StripePagos")]
    public class StripePago
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        // PedidoId es opcional (int?) porque si es una RECARGA de wallet será NULL
        public int? PedidoId { get; set; }

        [Required]
        [StringLength(255)]
        public string StripeSessionId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Monto { get; set; }

        [Required]
        [StringLength(20)]
        public string TipoOperacion { get; set; } // "COMPRA" o "RECARGA"

        [Required]
        [StringLength(50)]
        public string Estado { get; set; } // "pending", "completed", "failed"

        public DateTime Fecha { get; set; } = DateTime.Now;

        // Propiedades de navegación (opcionales, según tu arquitectura)
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("PedidoId")]
        public virtual Pedido Pedido { get; set; }
    }
}

