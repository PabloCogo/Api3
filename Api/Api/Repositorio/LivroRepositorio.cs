using Api.Context;
using Api.Entidades;
using Api.Repositorio.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Api.Repositorio
{
    public class LivroRepositorio : ILivroRepositorio
    {
        private readonly ApiContext _context;

        public LivroRepositorio(ApiContext context)
        {
            _context = context;
        }
        public bool Save(Livros livros)
        {
            try
            {
                if (livros.Id == 0)
                    _context.Livros.Add(livros);
                else
                    _context.Livros.Update(livros);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Livros> GetLivros()
        {
            return _context.Livros.ToList();
        }
        public Livros GetLivro(long id)
        {
            return _context.Livros.Where(c => c.Id == id).FirstOrDefault();
        }
        public bool DeleteLivro(long id)
        {
            try{
                _context.Livros.Remove(GetLivro(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
