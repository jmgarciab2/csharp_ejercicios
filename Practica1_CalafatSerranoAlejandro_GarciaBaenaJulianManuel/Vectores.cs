using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1_CalafatSerranoAlejandro_GarciaBaenaJulianManuel
{
    abstract class Vectores {
        double[] vector1;
        double[] vector2;

        protected Vectores(double[] vector1, double[] vector2)
        {
            this.vector1 = vector1;
            this.vector2 = vector2;
        }

        protected Vectores()
        {

        }

        public void SetVector1(double[] vector1) {
            vector1 = this.vector1;
        }
        public void SetVector2(double[] vector2){
            vector2 = this.vector1;
        }
        public double[] GetVector1() {
            return this.vector1;
        }

        public double[] GetVector2() {
            return this.vector2;
        }
        

        public abstract void ImprimirPorPantalla(double[] vector);
        public abstract double[] SumarVectores(double[] vector1, double[] vector2);
        public abstract double[] LeerVector(double[] vector); 
    
    }
}
