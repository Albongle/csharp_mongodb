using Entidades;

namespace csharp_mongodb;

class Program
{
    static void Main(string[] args)
    {
        Emisor emisor = new Emisor() { Nombre = "csharp", Apellido = "Consola", Edad = 7, Email = "csharp@consola.com" };
        Mensaje mensaje = new Mensaje() { Contenido = "Hola desde la consola Csharp", FechaEnvio = DateTime.Now.ToString() };

        Conversacion conversacion = new Conversacion() { Emisor = emisor, Mensaje = mensaje };
        MongoManager mongoManager = new MongoManager("chats");
        bool resultado = mongoManager.InsertOne<Conversacion>("conversacion", conversacion);
        Console.WriteLine(resultado);
        Console.WriteLine("Hello, World!");
    }
}
