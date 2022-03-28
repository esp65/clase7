using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase7.Clases
{
    internal class Carro
    {
        public string marca { get; }
        public int modelo { get; }
        public string color { get; set; }

        

        private int encendido = 0;
        private int apagar = 0;
        
        private int velocidad_actual = 0;
        // private const int maxvelocidad = 180;
        public int maxvelocidad { get; }
        


        public Carro(string _marca, int _modelo, string _color, int _maxvel)
        {
            marca = _marca;
            modelo = _modelo;
            color = _color;
            encendido = 0;
            maxvelocidad= _maxvel;
            this.velocidad_actual = 0;

        }

        public string Getvelocidadactual()
        {
            return $"Vamos a {velocidad_actual} KPH";

        }

        public void encender_motor()
        {
            if (encendido == 0)
            {
                Console.WriteLine("El carro ya esta listo para correr");
                encendido = 1;
            }
            else
            {
                if(apagar == 0)
                {
                    Console.WriteLine("El carro se encuentra apagado");
                    apagar = 0;
                }
            }          
        }

        public string acelerar()
        {
            string mensaje = "";
            
            velocidad_actual += 10;
            if (velocidad_actual >= maxvelocidad)
            {
                mensaje = $"Vas a { +velocidad_actual} KMP";
            }
               velocidad_actual = maxvelocidad;
                mensaje = $"{velocidad_actual} KMP Cuidado vas muy rapido, ya no puedes seguir acelerando llegaste a la velocidad maxima";

                    velocidad_actual -= 5;
                    if (velocidad_actual >= maxvelocidad)
                    {
                        mensaje = $"Acabas de bajar a { +velocidad_actual} KMP";
                    }
           Console.WriteLine(mensaje);
           return mensaje;           
        }
        public string acelerar(int cuantosKMP)
        {
            string mensaje = "";
            if (encendido == 0)
            {
                mensaje = ("No puedo acelerar con el carro apagado");
                return mensaje;
            }
            velocidad_actual += cuantosKMP;
            if (velocidad_actual <= maxvelocidad)
            {
                mensaje = $"Vas a { +velocidad_actual} KMP";
            }
            else
            {
                velocidad_actual = maxvelocidad;
                mensaje = $"{velocidad_actual} KMP Cuidado vas muy rapido, ya no puedes seguir acelerando llegaste a la velocidad maxima";
            }


            Console.WriteLine(mensaje);
            return mensaje;

        }

        

    
}   }
