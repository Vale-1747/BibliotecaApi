namespace BibliotecaApi.Interfaces;

public interface ILibroService
{
    List<Libro> getAll();

    Libro? GetById(int id);
}