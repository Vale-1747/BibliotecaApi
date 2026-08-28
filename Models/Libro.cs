namespace BibliotecaApi.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Tema { get; set; }

        public Libro(int id, string titulo, string autor, string isbn, string tema)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Tema = tema;
        }

        public Libro()
        {
            
        }
    }
}