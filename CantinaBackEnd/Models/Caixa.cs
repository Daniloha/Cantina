using CantinaBackEnd.Models.Base;

namespace CantinaBackEnd.Models
{
    public class Caixa : BaseModel
    {
        public double SaldoCaixa { get; set; }
        public Cantina cantina { get; set; }
        public Admin GestorAdmin { get; set; }
    }
}
