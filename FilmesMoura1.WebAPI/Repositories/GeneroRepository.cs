using FilmesMoura1.WebAPI.BdContextFilme;
using FilmesMoura1.WebAPI.Interfaces;
using FilmesMoura1.WebAPI.Models;

namespace FilmesMoura1.WebAPI.Repositories;

public class GeneroRepository : IGeneroRepository
{
    private readonly FilmeContext _context;

    public GeneroRepository(FilmeContext context)
    {
        _context = context;
    }

    public void atualizarIdCorpo(Genero generoAtualizado)
    {
        try
        {
            Genero generoBuscando = _context.Generos.Find(generoAtualizado.IdGenero)!;

            if (generoBuscando != null)
            {
                generoBuscando.Nome = generoAtualizado.Nome;
            }

            _context.Generos.Update(generoBuscando);
            _context.SaveChanges();

        }
        catch (Exception)
        {

            throw;
        }
    }

    public void atualizarIdUrl(Guid id, Genero generoAtualizado)
    {
        try
        {
            Genero generoBuscando = _context.Generos.Find(id.ToString()!);

            if (generoBuscando != null)
            {
                generoBuscando.Nome = generoAtualizado.Nome;
            }

            _context.Generos.Update(generoBuscando!);
            _context.SaveChanges();
        }
        catch (Exception)
        {
            throw;
        }
        try
        {
            Genero generoBuscando = _context.Generos.Find(id.ToString()!);

            if (generoBuscando != null)
            {
                generoBuscando.Nome = generoAtualizado.Nome;
            }

            _context.Generos.Update(generoBuscando!);
            _context.SaveChanges();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public Genero BuscaPorld(Guid id)
    {
        try
        {
            Genero generoBuscando = _context.Generos.Find(id.ToString());
            return generoBuscando;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Cadastrar(Genero novoGenero)
    {
        try
        {
            novoGenero.IdGenero = Guid.NewGuid().ToString();
            _context.Generos.Add(novoGenero);

            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw;
        }


    }


    public void Deletar(Guid id)
    {
        try
        {
            Genero generoBuscando = _context.Generos.Find(id.ToString())!;

            if (generoBuscando != null)
            {
                _context.Generos.Remove(generoBuscando);
            }
            _context.SaveChanges();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public List<Genero> Listar()
    {
        try
        {
            List<Genero> lisrarGenero = _context.Generos.ToList();
            return lisrarGenero;
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}