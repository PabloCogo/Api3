using Api.Entidades;
using System.Collections.Generic;

namespace Api.Repositorio.Interface
{
    public interface ILivroRepositorio
    { 
        bool Save(Livros livros);
        List<Livros> GetLivros();
        Livros GetLivro(long id);
        bool DeleteLivro(long id);
    }
}
