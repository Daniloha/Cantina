using CantinaBackEnd.Models.Enums;

namespace CantinaBackEnd.Data.DTO
{
    public class ProdutoDTO
    {
        public long IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int QuantEstoque { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }
    }
}
