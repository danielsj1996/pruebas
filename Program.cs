using ClaseJson;
using System.Net;
using System.Text.Json;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Personajes personajes1 = new Personajes();
personajes1.name ="";
personajes1.role = "";
personajes1.lore = "";
personajes1.abilities = new List<string>();

 try
            {

                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string Lineas = objReader.ReadToEnd();
                            Personajes personajes = JsonSerializer.Deserialize<Personajes>(Lineas);

                                
                                Console.WriteLine("Nombre: " + personajes.name );
                                Console.WriteLine("Rol: " + personajes.role );
                                Console.WriteLine("Lore: " + personajes.lore);
                                Console.WriteLine("Lore: " + personajes.lore);
                                Console.WriteLine("HAbilidad1: " + personajes.abilities);
                                

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Problemas de acceso a la API");
            }
        
