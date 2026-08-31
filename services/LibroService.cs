using BibliotecaApi.Models;
using BibliotecaApi.Interfaces;

namespace BibliotecaApi.Services
{
    public class LibroService : ILibroService
    {
        private static List<Libro> _libros = new()
        {
            new Libro { Id = 1, Titulo = "El Principito", Autor = "Antoine de Saint-Exupéry", ISBN = "978-3-16-148410-0", Tema = "Ficción" },
            new Libro { Id = 2, Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez", ISBN = "978-3-16-148410-1", Tema = "Realismo Mágico" },
            new Libro { Id = 3, Titulo = "1984", Autor = "George Orwell", ISBN = "978-3-16-148410-2", Tema = "Distopía" }
        };

        public List<Libro> getAll() 
        {
            return _libros;
        }

        public Libro GetById(int id)
        {
            return _libros.FirstOrDefault(l => l.Id == id);
        }
    }
}