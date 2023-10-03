namespace Entidades
{
    public class Conversacion
    {
        public Emisor Emisor { get; set; }
        public Mensaje? Mensaje { get; set; }
        public Receptor? Receptor { get; set; }
    }

}