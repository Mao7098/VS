Console.WriteLine("Hello, World!");

// Crear objetos
Personas persona = new Personas();
var persona1 = new Personas();

// Asignar valores a las propiedades
persona.Id = 1;
persona.Nombre = "Pepito Perez";
persona.Estatura = 1.60m;
persona.Vive = false;
persona.Fecha = DateTime.Now;
persona.Estado = new Estados() { Id = 1, Nombre = "Viudo" };

// Lista de objetos
persona.VideoJuegos = new List<VideoJuegos>();
persona.VideoJuegos.Add(new VideoJuegos() { Id = 1, Nombre = "GTA" });
persona.VideoJuegos.Add(new VideoJuegos() { Id = 2, Nombre = "DOOM" });

// Imprimir en consola
Console.WriteLine(persona.Nombre);
Console.WriteLine(persona.Estado.Nombre);

// Recorrer lista con foreach
foreach (var elemento in persona.VideoJuegos)
{
    Console.WriteLine(elemento.Nombre);
}

// Clases de apoyo
public class Estados
{
    public int Id;
    public string? Nombre;
    public List<Personas>? Personas;
}

public class VideoJuegos
{
    public int Id;
    public string? Nombre;
}

public class Personas
{
    public int Id;
    public string? Nombre;
    public decimal Estatura;
    public bool Vive;
    public DateTime Fecha;
    public Estados? Estado;
    public List<VideoJuegos>? VideoJuegos;
}
