using System;

namespace Inuyasha
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var personajePrincipal = new Personaje("inuyasha", 16)
            {
                Nombre = "inuyasha",
                Edad = 15,
                Arma = "colmillo de acero"
            };

            var amigo = new Amigo("aome", 15)
            {
                Nombre = "aome",
                Edad = 16
            };
            var amigo2 = new Amigo("aome", 15)
            {
                Nombre = "shipo",
                Edad = 10
            };
            var amigo3 = new Amigo("aome", 15)
            {
                Nombre = "miroku",
                Edad = 20
            };
            var amigo4 = new Amigo("aome", 15)
            {
                Nombre = "sango",
                Edad = 20
            };
            var enemigo = new Enemigo("naraku", 23)
            {
                Nombre= "naraku",
                Edad=23
            };
            var objetivo = new Objetivo()
            {
                Nombre="recuperar la perla de shikon",
                Lugar=$"cueva de {enemigo.Nombre}"
            };
            var arma = new Arma()
            {
                Nombre="colmillo de acero",
                Dueño= $"{personajePrincipal.Nombre}"
            };



            Console.WriteLine(personajePrincipal.Saludar());
            Console.WriteLine(personajePrincipal.EnseñarArma());

            Console.WriteLine("quieres conocer a mis amigos (escribe si o no)");
            string texto;
            texto = Console.ReadLine();
            if (texto == "si")
            {
                Console.WriteLine(amigo.PresentacionAmigos());
                Console.WriteLine(amigo2.PresentacionAmigos());
                Console.WriteLine(amigo3.PresentacionAmigos());
                Console.WriteLine(amigo4.PresentacionAmigos());
                Console.WriteLine("¿Cómo te llamas?");
                
            }
          
          
            else
            {
                Console.WriteLine("adios");
            }
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine($"Estamos felices de conocerte {nombreUsuario}");
            


            if (nombreUsuario.Length > 0)
            {
                Console.WriteLine($"Yo no estoy muy feliz {nombreUsuario}");
                Console.WriteLine(enemigo.PresentacionEnemigo());
            }

            Console.WriteLine($"quieres empezar {nombreUsuario} (escribe cualquier cosa)");
            string respuesta = Console.ReadLine();
            if (respuesta.Length > 0)
            {
                Console.WriteLine(objetivo.presentarObjetivo());
                Console.WriteLine("empezamos? escribe si o no");
                string respuesta2 = Console.ReadLine();
                if (respuesta2 == "si")
                {
                    Console.WriteLine($"genial {nombreUsuario} empecemos!!!!");
                    Console.WriteLine(arma.EnseñarArmaObjetivo());
                    Console.WriteLine("Escribe Algo");
                    string despedida = Console.ReadLine();
                    Console.WriteLine("upsss!! ya se nos hizo tarde te recomendamos ver el capitulo 69 de inuyasha!!1 hasta la proximaaa :3");
                }
                else
                {
                    Console.WriteLine($"Hasta la proxima{nombreUsuario} ");
                }
            }



        }

    }

}

