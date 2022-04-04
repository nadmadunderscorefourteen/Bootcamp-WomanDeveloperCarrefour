using System;

class Program {
    static void Main(string[] args) { 

             double a, b, c, delta, resultadoPositivo, resultadoNegativo;
             string[] valor = Console.ReadLine().Split(" ");

             a = Convert.ToDouble(valor[0]);
             b = Convert.ToDouble(valor[1]);
             c = Convert.ToDouble(valor[2]);

             delta = Math.Pow(b, 2) - (4 * a * c);
             resultadoPositivo = (-b + Math.Sqrt(delta)) / (2 * a);
             resultadoNegativo = (-b - Math.Sqrt(delta)) / (2 * a);

             if ( a == 0 || delta < 0 )
             {
               Console.WriteLine("Impossivel calcular");
             }
             else
             {
               Console.WriteLine("R1 = {0:F5}", resultadoPositivo);
               Console.WriteLine("R2 = {0:F5}", resultadoNegativo); 
             }
    }
}