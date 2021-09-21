using System;
using System.Collections.Generic;
using System.Text;


namespace Practica1_CalafatSerranoAlejandro_GarciaBaenaJulianManuel
{
    class Vec2DP : Vectores
    {
        public override void ImprimirPorPantalla(double[] vector)
        {
            Console.WriteLine("Vector mostrado: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Posicion " + i + ": " + vector[i] + "\n");

            }
        }

        public override double[] LeerVector(ref double[] vector)
        {
            Console.WriteLine("Introduzca las coordenada del vector: \n");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Coordenada " + i + " : ");
                vector[i] = double.Parse(Console.ReadLine());
            }
            return vector;
        }

        public override double[] SumarVectores(double[] vector1, double[] vector2)
        {
            double[] resultado = new double[2];
            resultado[0] = vector1[0] + vector2[0];
            resultado[1] = vector1[1] + vector2[1];
            return resultado;
        }

        public double[] PolarACartesiana(double[] vector1) {
            double[] resultado = new double[2];
            resultado[0] = Math.Sqrt(Math.Pow(vector1[0], 2) + Math.Pow(vector1[1], 2));
            resultado[1] = Math.Atan(vector1[1]/vector1[0]);
            return vector1;
        }
         
        public double[] CartesianaAPolar(double[] vector1) {
            double[] resultado = new double[2];
            resultado[0] = vector1[0] * Math.Cos(vector1[1]);
            resultado[1] = vector1[0] * Math.Sin(vector1[1]);
            return vector1;
        }

    }
}
