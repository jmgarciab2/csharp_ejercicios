using System;

namespace Practica1_CalafatSerranoAlejandro_GarciaBaenaJulianManuel
{
    // 1- Sumar 2 vectores de 2 dimensiones en coordenadas cartesianas. Pide las coordenadas cartesianas de los vectores de dos dimensiones por pantalla. Realiza la suma y muestra el resultado por pantalla en coordenadas cartesianas.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la opcion a realizar:");
            int opcion;
            opcion = int.Parse(Console.ReadLine());
            switch (opcion) {
                case 1:
                    ApartadoA();
                    break;
                case 2:
                    ApartadoB();
                    break;
                case 3:
                    ApartadoC();
                    break;
            }
            

        }

        static void ApartadoA()
        {
            double[] vector1 = new double[2];
            double[] vector2 = new double[2];
            Vec2DC vectorResultado = new Vec2DC();
            vectorResultado.LeerVector(vector1);
            vectorResultado.LeerVector(vector2);
            double[] resultado = vectorResultado.SumarVectores(vector1, vector2);
            Console.WriteLine("El resultado de la suma de los vectores es: ");
            vectorResultado.ImprimirPorPantalla(resultado);
        }

        static void ApartadoB()
        {
            double[] vector1 = new double[3];
            double[] vector2 = new double[3];
            Vec3DC vectorResultado = new Vec3DC();
            vectorResultado.LeerVector(vector1);
            vectorResultado.LeerVector(vector2);
            double[] resultado = vectorResultado.SumarVectores(vector1, vector2);
            Console.WriteLine("El resultado de la suma de los vectores es: ");
            vectorResultado.ImprimirPorPantalla(resultado);
        }

        private static void ApartadoC() {
            double[] vector1 = new double[2];
            double[] vector2 = new double[2];
            Vec2DP vec2DP = new Vec2DP();
            double[] resultado1 = vec2DP.LeerVector(vector1);
            double[] resultado2 = vec2DP.LeerVector(vector2);
            double[] resultadoCartesiana1 = vec2DP.PolarACartesiana(resultado1);
            double[] resultadoCartesiana2 = vec2DP.PolarACartesiana(resultado2);
            double[] resultadoSuma = vec2DP.SumarVectores(resultadoCartesiana1 , resultadoCartesiana2);
            double[] resultadoCartesiana = vec2DP.CartesianaAPolar(resultadoSuma);
            vec2DP.ImprimirPorPantalla(resultadoCartesiana);
        }

        

        static void ApartadoD() { 
        }

       
    }
}
