namespace Inuyasha
{

    public class Amigo : Personaje
    {




    
        public Amigo(string nombre, int edad):base(nombre,edad)
        {

        }
        

        public string PresentacionAmigos()
        {
            return $"hola mi nombre es {this.Nombre} y tengo {this.Edad} años";
        }
       
    }
}



