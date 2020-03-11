
namespace OpenClose
{
    abstract class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public abstract string draw();
    }
}
