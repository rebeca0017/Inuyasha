namespace Inuyasha
{
    public class Enemigo:Personaje
    {
       public Personaje Personaje { get; set; }
        public Enemigo(string nombre, int edad) : base(nombre, edad)
        {

        }

        public string PresentacionEnemigo()
        {
            return $"Yo soy  {this.Nombre} y tengo {this.Edad} años soy el mayor Enemigo ";
        }
    }

}