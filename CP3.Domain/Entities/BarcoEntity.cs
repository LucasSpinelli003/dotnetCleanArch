using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP3.Domain.Entities
{
    [Table("tb_barco")]
    public class BarcoEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Modelo { get; set; }
        public double  Tamanho { get; set; }
    }
}
