using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace WebPostgreSQL.Models
{
    [Table("CLIENTES")]
    public class Cliente
    {
        [Key]
        [Column("Codigo")]
        [Display(Name = "Código")]
        public int CodigoCliente { get; set; }

        [Required(ErrorMessage ="Nome Obrigatório")]
        [Column("Nome")]
        [Display(Name = "Nome")]
        public String? Nome { get; set; }

        [Required(ErrorMessage ="CNPJ Obrigatório")]
        [Column("CNPJ")]
        [Display(Name = "CNPJ")]
        public String? CNPJ { get; set; }

        [Column("DataCadastro")]
        [Display(Name = "Data de Cadastro")]
        public DateOnly? DataCadastro { get; set; }

        [Required(ErrorMessage = "Endereço Obrigatório")]
        [Column("Endereco")]
        [Display(Name = "Endereço")]
        public String? Endereco { get; set; }

        [Required(ErrorMessage = "Telefone Obrigatório")]
        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }
        
    }
}
