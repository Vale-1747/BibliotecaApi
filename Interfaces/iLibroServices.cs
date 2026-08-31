using BibliotecaApi.Models;

namespace BibliotecaApi.Interfaces;

public interface iLibroService
{
    
    public List<Libro> getAll();
    public Libro? ObtenerPorId(int id);

    public Libro Crear(Libro nuevoLibro);

    public bool Actualizar(int id, Libro libroActualizado);

    public bool Eliminar(int id);
    
}