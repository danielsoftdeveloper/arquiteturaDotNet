using webapi.InputModel;
using webapi.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace webapi.Services
{
    public interface IJogoService : IJogoService
    {
       Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}