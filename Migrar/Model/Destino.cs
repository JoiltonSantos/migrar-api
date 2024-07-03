using System.ComponentModel.DataAnnotations.Schema;

namespace Migrar.Model
{
    [Table("destinos")]
    public class Destino
    {
        [Column("id_destino")]
        public int Id { get; set; }

        [Column("local_destino")]
        public string Local { get; set; } = string.Empty;

        [Column("foto_destino")]
        public string Foto { get; set; } = string.Empty;

        [Column("valor_destino")]
        public decimal Valor { get; set; }
    }
}