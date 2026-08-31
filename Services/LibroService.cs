using BibliotecaApi.Models;
using BibliotecaApi.Interfaces;

namespace BibliotecaApi.Services;

public class LibroService:iLibroService
{
    private static readonly List<Libro> _libros = new()
    {
        new Libro { Id = 1, Titulo = "C# en Profundidad",  ISBN = "978-1-61729-453-2", Tema = "Programación", Autor = "Jon Skeet" },
        new Libro { Id = 2, Titulo = "Clean Code", ISBN = "978-0-13-235088-4", Tema = "Arquitectura de Software", Autor = "Robert C. Martin" },
        new Libro { Id = 3, Titulo = "Diseño de Patrones", ISBN = "978-0-201-63361-0", Tema = "Ingeniería de Software", Autor = "Erich Gamma" }
    };

    public List<Libro> getAll() => _libros;

    public Libro? ObtenerPorId(int id) => _libros.FirstOrDefault(l => l.Id == id);

    public Libro Crear(Libro nuevoLibro)
    {
        nuevoLibro.Id = _libros.Count > 0 ? _libros.Max(l => l.Id) + 1 : 1;
        _libros.Add(nuevoLibro);
        return nuevoLibro;
    }

    public bool Actualizar(int id, Libro libroActualizado)
    {
        var index = _libros.FindIndex(l => l.Id == id);
        if (index == -1) return false;

        libroActualizado.Id = id; // Mantener el ID original
        _libros[index] = libroActualizado;
        return true;
    }

    public bool Eliminar(int id)
    {
        var libro = ObtenerPorId(id);
        if (libro == null) return false;

        _libros.Remove(libro);
        return true;
    }
}

