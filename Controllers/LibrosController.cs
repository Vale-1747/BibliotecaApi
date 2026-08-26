using Microsoft.AspNetCore.Mvc;
using BibliotecaApi.Models;

namespace BibliotecaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LibrosController: ControllerBase
{
    // Lista de libros, datos cargados en memoria
    private static List<Libro> _libros = new()
    {
        new Libro(1,"Titulo 1", "Autor 1", "1234", "Tema 1"
        ),
        new Libro(2, "Titulo 2", "Autor 2", "1234", "Tema 2"
        ),
        new Libro(3, "Titulo 3", "Autor 3", "4569", "Tema 2"
        )

    };

    //Get para obtener todos los libros
    [HttpGet]
    public ActionResult<IEnumerable<Libro>> GetAll()
    {
       
        return Ok(_libros);
    } 

    // Get con dato enviado en la ruta para filtrar un solo libro
    [HttpGet("{id}")]
    public  ActionResult<Libro> GetById(int id)
    {
        Libro libro = _libros.FirstOrDefault(l => l.Id == id);

        if(libro != null)
        {
            return Ok(libro);
        }
        else{ return NotFound("Libro no encontrado");}
    }
}

