
using CantinaBackEnd.Models;

namespace CantinaBackEnd.Data.DTO
{
    public class CaixaDTO 
    {
        public long IdCaixa { get; set; }
        public double SaldoCaixa { get; set; }
        public Cantina cantina { get; set; }
        public Admin GestorAdmin { get; set; }

    }
}
