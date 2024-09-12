using CantinaBackEnd.Data.Contract;
using CantinaBackEnd.Data.DTO;
using CantinaBackEnd.Models;

namespace WebApiCadastro.Data.Converter.Implementations
{
    public class BookConverter : IParser<FuncionarioDTO, Funcionario>, IParser<Funcionario, FuncionarioDTO>
    {
        public Funcionario Parse(FuncionarioDTO origin)
        {
            if (origin == null) return null;
            return new Funcionario
            {
                NomeFuncionario = origin.NomeFuncionario,
                CargoFuncionario = origin.CargoFuncionario,
                LocalTrabalho = origin.LocalTrabalho
            };
        }

        public FuncionarioDTO Parse(Funcionario origin)
        {
            if (origin == null) return null;
            return new FuncionarioDTO
            {

                NomeFuncionario = origin.NomeFuncionario,
                CargoFuncionario = origin.CargoFuncionario,
                LocalTrabalho = origin.LocalTrabalho
            };
        }

        public List<Funcionario> Parse(List<FuncionarioDTO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<FuncionarioDTO> Parse(List<Funcionario> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
