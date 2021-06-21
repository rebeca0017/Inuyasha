using System.Collections.Generic;

namespace Inuyasha
{

    class Arma
    {
        public string Nombre { get; set; }
        public List<Habilidad> Habilidades { get; set; }
        public string Dueño { get; set; }
        public int Edad { get; set; }

        public string  Transformacion { get; set; }

        public string EnseñarArmaObjetivo()
        {
            return $"en esta ocasion usaremos a {this.Nombre} quien pertenece a {this.Dueño}";
        }

    }

    
}

