using CantinaBackEnd.Models.Base;

namespace CantinaBackEnd.Models
{
    public class Admin : BaseModel
    {
        public string LoginAdmin { get; set; }

        public string SenhaAdmin { get; set; }
        public ICollection<Funcionario> TimeFuncionarios { get; set; }

        public ICollection<Cantina> CantinasAtuacao { get; set; }
    }
}
