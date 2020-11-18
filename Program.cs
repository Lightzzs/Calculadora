using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja ver a tabuada de qual número ?");
            int resposta = int.Parse(Console.ReadLine());
            
            int resultado;
            
            for (int contador = 0; contador <=10; contador++)        
            {
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");   
            }
        }
    }
}
