using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend_PUC_MG.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Descrição")]
        [Required(ErrorMessage ="Obrigatorio informar uma descrição!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a quilometragem!")]
        public int Km { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Obrigatorio informar um valor!")]
        public decimal Valor { get; set; }

        [Display(Name = "Tipo de combustível")]
        [Required(ErrorMessage = "Obrigatorio informar o tipo!")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatorio informar o veiculo!")]
        public int VeiculoId{ get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; } 
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
