using Api.Entidades;
using Api.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LivroController:Controller
    {
        private readonly ILivroRepositorio _livroRepositorio;
        public LivroController(ILivroRepositorio livroRepositorio)
        {
            _livroRepositorio = livroRepositorio;
        }
        [HttpPost]
        [Route("insert-book")]
        public bool InsertBook([FromBody]Livros livros)
        {
            try 
            {
                return _livroRepositorio.Save(livros);
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("getBooks")]
        public List<Livros> GetBooks()
        {
            return _livroRepositorio.GetLivros();
        }
        [HttpGet]
        [Route("getBook")]
        public Livros GetLivro(long id)
        {
            return _livroRepositorio.GetLivro(id);
        }
        [HttpDelete]
        [Route("deleteBook")]
        public bool DeleteBook(long id)
        {
            try
            {
                return _livroRepositorio.DeleteLivro(id);
            }
            catch
            {
                return false;
            }
        }

    }
}
