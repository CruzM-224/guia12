using System;

struct cancion {
  public string artista;
  public string titulo;
  public Double duracion;
  public Double size;
}

class MainClass {
  public static void Main (string[] args) {
    cancion cancion1 = new cancion();

    Console.WriteLine("Ingrese los datos de la cancion");
    
    Console.Write("Artista: ");
    cancion1.artista = Console.ReadLine();

    Console.Write("Titulo: ");
    cancion1.titulo = Console.ReadLine();

    Console.Write("Duracion en segundos: ");
    cancion1.duracion = Double.Parse(Console.ReadLine());

    Console.Write("Tamaño en KB: ");
    cancion1.size = Double.Parse(Console.ReadLine());

    Console.Clear();

    Console.WriteLine("Artista: " + cancion1.artista);

    Console.WriteLine("Titulo: " + cancion1.titulo);

    Console.WriteLine("Duracion en segundos: " + cancion1.duracion + " seg");

    Console.WriteLine("Tamaño: " + cancion1.size + " KB");
  }
}