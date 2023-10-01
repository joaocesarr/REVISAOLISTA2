using Revisao.Application.ViewModels;


namespace Revisao.Application.Interfaces
{
    public interface IJogoServico
    {
        bool Adicionar(NovoMegaSenaViewModel novoMegaSenaViewModel);
        Task<IEnumerable<MegaSenaViewModel>> ObterTodos();
    }
}
