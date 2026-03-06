using FilmesMoura1.WebAPI.Models;

namespace FilmesMoura1.WebAPI.Interfaces
{
    public interface IGeneroRepository
    {
        Genero BuscaPorld(Guid id);
        List<Genero> Listar();

        void atualizarIdCorpo(Genero generoAtualizado);

        void atualizarIdUrl(Guid id, Genero generoAtualizado);

        void Cadastrar(Genero novoGenero);
        void Deletar(Guid id);
    }
}
