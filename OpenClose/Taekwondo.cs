using System.Collections.Generic;

namespace OpenClose
{
    class Taekwondo : Persona
    {
        public List<string> Pumses { set; get; }
        public override string draw()
        {
            return "Yo practico Taekwondo";
        }
    }
}
