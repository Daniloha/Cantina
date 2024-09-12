using CantinaBackEnd.Models.Base;
using CantinaBackEnd.Models.Enums;

namespace CantinaBackEnd.Models
{
    public class Produto : BaseModel
    {

        public string NomeProduto { get; set; }
        public int QuantEstoque { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }
        public Cantina cantina { get; set; }
    }
}
