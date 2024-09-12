using CantinaBackEnd.Models;
using CantinaBackEnd.Models.Enums;

namespace CantinaBackEnd.Data.DTO
{
    public class FuncionarioDTO
    {
        public string NomeFuncionario { get; set; }
        public Cargo CargoFuncionario { get; set; }
        public Cantina LocalTrabalho { get; set; }
    }
}
