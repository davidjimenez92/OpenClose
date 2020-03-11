using System.Collections.Generic;

namespace OpenClose
{
    class Karateka : Persona
    {
        public List<string> Katas { set; get; }

        public override string draw()
        {
            return "Hola soy un karateka";
        }
    }
}
