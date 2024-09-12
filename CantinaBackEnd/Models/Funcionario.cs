using CantinaBackEnd.Models.Base;
using CantinaBackEnd.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace CantinaBackEnd.Models
{
    [Table("funcionarios")]
    public class Funcionario : BaseModel
    {
        [Column("nome_funcionario")]
        public string NomeFuncionario { get; set; }
        [Column("cpf_funcionario")]
        public string CpfFuncionario { get; set; }
        [Column("cargo_funcionario")]
        public Cargo CargoFuncionario { get; set; }
        [Column("email_funcionario")]
        public string EmailFuncionario { get; set; }
        [Column("senha_funcionario")]
        public string SenhaFuncionario { get; set; }
        public Telefone TelefoneFuncionario { get; set; }

        public Endereco EnderecoFuncionario { get; set; }
        public Admin GestorAdmin { get; set; }
        public Cantina LocalTrabalho { get; set; }

    }
}
