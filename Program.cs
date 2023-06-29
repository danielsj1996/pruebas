using ClaseJson;
using System.Net;
using System.Text.Json;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string fileName = "Personajes.json";
string archivo = "Personajes.txt";
var miHelperdeArchivos = new HelperDeJson();
//Abro el Archivo
Console.WriteLine("--Abriendo--");
string jsonDocument = miHelperdeArchivos.AbrirArchivoTexto(fileName);
Console.WriteLine("--Deserializando--");
var personajesrecuperados = JsonSerializer.Deserialize<List<Personajes>>(jsonDocument);
Console.WriteLine("--Mostrando datos recuperardos--");
#pragma warning disable
ImprimirAlumnos(personajesrecuperados);
#pragma warning restore

GuardarArchivoTexto(personajesrecuperados, archivo);

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


static void GuardarArchivoTexto(List<Personajes> personajes, string archivo)
{
    using (StreamWriter writer = new StreamWriter(archivo,true))
    {
        writer.WriteLine("Personajes");

        for (int i = 0; i < personajes.Count; i++)
        {
            string? nombre = personajes[i].name;
            string? role = personajes[i].role;
            string? lore = personajes[i].lore;
            string hab1 = personajes[i].abilities[0];
            string hab2 = personajes[i].abilities[1];
            string hab3 = personajes[i].abilities[2];
            string hab4 = personajes[i].abilities[3];

      
            writer.WriteLine($"Nombre: {nombre}");
            writer.WriteLine($"Rol: {role}");
            writer.WriteLine($"Lore: {lore}");
            writer.WriteLine($"Habilidades:");
            writer.WriteLine($"Hab1: {hab1}");
            writer.WriteLine($"Hab2: {hab2}");
            writer.WriteLine($"Hab3: {hab3}");
            writer.WriteLine($"Hab4: {hab4}");
            writer.WriteLine("\n");
        }


        }
    }

