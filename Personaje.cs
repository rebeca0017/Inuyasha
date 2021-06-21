using System.Collections.Generic;

namespace Inuyasha
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public List<Habilidad> Habilidades { get; set; }

        public string Vestimenta { get; set; }

        public string tipo { get; set; }

        public List<Enemigo> Enemigos { get; set; }

        public string Arma { get; set; }

        public string Objetivo { get; set; }

        public List<Amigo> Amigos { get; set; }

        public string Identidad { get; set; }

   public Personaje(string nombre, int edad)
        {
            
        }
        public string Saludar()
        {
            return $"mi nombre es {this.Nombre} un gusto conocerte";
        }

        public string EnseñarArma()
        {
            return $"esta es mi arma {this.Arma} y ellos son mis amigos {this.Amigos}";
        }

    }

    

}
