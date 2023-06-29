using ClaseJson;
using System.Net;
using System.Text.Json;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string fileName = "Personajes.json";
var miHelperdeArchivos = new HelperDeJson();
//Abro el Archivo
Console.WriteLine("--Abriendo--");
string jsonDocument = miHelperdeArchivos.AbrirArchivoTexto(fileName);
Console.WriteLine("--Deserializando--");
var personajesrecuperados = JsonSerializer.Deserialize<List<Personajes>>(jsonDocument);
Console.WriteLine("--Mostrando datos recuperardos--");
ImprimirAlumnos(personajesrecuperados);


void ImprimirAlumnos(List<Personajes> personajes)
{
    foreach (var item in personajes)
    {

        Console.WriteLine("\n");
        Console.WriteLine("\nNombre: " + item.name);
        Console.WriteLine("\nRol: " + item.role);
        Console.WriteLine("\nLore: " + item.lore);
        Console.WriteLine("\nHabilidad1: " + item.abilities[0]);
        Console.WriteLine("\nHabilidad2: " + item.abilities[1]);
        Console.WriteLine("\nHabilidad3: " + item.abilities[2]);
        Console.WriteLine("\nHabilidad4: " + item.abilities[3]);
        Console.WriteLine("\n");
    }

}
