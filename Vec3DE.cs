using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1_CalafatSerranoAlejandro_GarciaBaenaJulianManuel
{
    class Vec3DE : Vectores
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
            throw new NotImplementedException();
        }
    }
}
