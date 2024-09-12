using CantinaBackEnd.Data.DTO;
using CantinaBackEnd.Models;

namespace CantinaBackEnd.Business
{
    public interface IFuncionarioBusiness
    {
        FuncionarioDTO GetFuncionario(long id);
        List<FuncionarioDTO> GetFuncionarios();
        Funcionario AddFuncionario(Funcionario funcionario);
        Funcionario UpdateFuncionario(Funcionario funcionario);
        void DeleteFuncionario(long id);
    }
}
