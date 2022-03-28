
using clase7.Clases;

Carro micarro = new Carro("mitsubishi",2022,"Azul");
Carro carroYuliana = new Carro("Nissan", 2022, "Rojo");

if (micarro.modelo > carroYuliana.modelo)
{
    Console.WriteLine("El carro carro del profe es mas reciente");
}
else
{
    Console.WriteLine("El carro carro de Yuliana es mas reciente");
}

//Console.WriteLine("Teacher is " + micarro.marca);
Console.WriteLine("Yuliana's car is " + carroYuliana.marca);
//Console.WriteLine("Yuliana's model car is " + carroYuliana.modelo);
Console.WriteLine(carroYuliana.Getvelocidadactual());

carroYuliana.encender_motor();

for (int i = 0; i < 50; i++)
{
   carroYuliana.acelerar(3);
}

carroYuliana.acelerar();

