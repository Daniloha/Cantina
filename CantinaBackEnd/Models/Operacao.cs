using CantinaBackEnd.Models.Base;
using CantinaBackEnd.Models.Enums;

namespace CantinaBackEnd.Models
{
    public class Operacao : BaseModel
    {
        public TipoOperacao tipoOperacao { get; set; }
        public DateOnly dataOperacao { get; set; }
        public ICollection<Produto> produtos { get; set; }
        public Cantina cantina { get; set; }
        public Funcionario funcionario { get; set; }
        public StatusOperacao statusOperacao { get; set; }

    }
}
