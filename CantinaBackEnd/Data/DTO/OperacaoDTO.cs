using CantinaBackEnd.Models.Enums;

namespace CantinaBackEnd.Data.DTO
{
    public class OperacaoDTO 
    {
        public long IdOperacao { get; set; }
        public TipoOperacao tipoOperacao { get; set; }
        public DateOnly dataOperacao { get; set; }
   

    }
}
