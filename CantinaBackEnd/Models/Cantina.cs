using CantinaBackEnd.Models.Base;

namespace CantinaBackEnd.Models
{
    public class Cantina : BaseModel
    {
        public string NomeCantina { get; set; }
        public string CnpjCantina { get; set; }
        public string EmailCantina { get; set; }
        public Telefone TelefoneCantina { get; set; }
        public Admin GestorAdmin { get; set; }
        public Endereco EnderecoCantina { get; set; }
        public ICollection<Funcionario> FuncionariosCantina { get; set; }
        public Caixa CaixaCantina { get; set; }
        public ICollection<Produto> ProdutosCantina { get; set; }
        public ICollection<Operacao> OperacoesCantina { get; set; }

    }
}
