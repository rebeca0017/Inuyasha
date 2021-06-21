using System.Collections.Generic;
namespace Inuyasha
{
    
        class Objetivo
        {
        public string Nombre { get; set; }
        public string Lugar { get; set; }
        public string Ganancia { get; set; }
        public string Circunstacia { get; set; }

        public List<Enemigo> Enemigos { get; set; }

        public Personaje Personaje { get; set; }

        public string Hallazgo { get; set; }


        public string presentarObjetivo()
        {
            return $"nuestro objetivo se llama {this.Nombre}, y  el lugar es {this.Lugar}";
        }

    }
    }

