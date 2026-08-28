using Microsoft.AspNetCore.Mvc;
using BibliotecaApi.Models;

namespace BibliotecaApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class LibrosController : ControllerBase
{
    private static List<Libro> _libros = new()
    {
        new Libro { Id = 1, Titulo = "El Principito", Autor = "Antoine de Saint-Exupéry", ISBN = "978-3-16-148410-0", Tema = "Ficción" },
        new Libro { Id = 2, Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez", ISBN = "978-3-16-148410-1", Tema = "Realismo Mágico" },
        new Libro { Id = 3, Titulo = "1984", Autor = "George Orwell", ISBN = "978-3-16-148410-2", Tema = "Distopía" }
    };
    [HttpGet]
    public ActionResult<IEnumerable<Libro>> GetAll()
    {
        return Ok(_libros);
    }

    [HttpGet("{id}")]
    public ActionResult<Libro> GetById(int id)
    {
        Libro libro = _libros.FirstOrDefault(l => l.Id == id);
        if (libro != null)
        {
            return Ok(libro);
        }
        else
        {
            return NotFound("Libro no encontrado");
        }
    }
}

