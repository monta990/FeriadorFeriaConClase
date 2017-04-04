using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjetosVisual
{
    class Feriador
    //class Form1
    {
        private int b50; //Variable para Billetes 50
        private int m5;  //Variable para monedad 5
        private int m1;  //Variable para monedad 1
        public int ObtenerB50() //Funcion: hace algo y regresa resultado
        {
            return this.b50;
        }
        public int ObtenerM5() //Funcion: hace algo y regresa resultado
        {
            return this.m5; //this indica que lavariable pertenecea esta clase u objeto.
        }
        public int ObtenerM1()
        {
            return this.m1;
        }
        private void LimpiarValores() //void indica que es un metodo. iguala las variables a 0
        {
            this.b50 = 0;
            this.m5 = 0;
            this.m1 = 0;
        }
        //constructor se llama igual que la clase.
        public Feriador()
        {
            this.LimpiarValores();
        }
        public void calcular(int cantidad) //Metodo que calcula la feria con le parametro entre parentesis.
        {
            int cantidadActual = cantidad;
            this.LimpiarValores();
            while (cantidadActual >= 50)
            {
                cantidadActual -= 50;
                this.b50++;
            }
            while (cantidadActual >= 5)
            {
                cantidadActual -= 5;
                this.m5++;
            }
            while (cantidadActual >= 1)
            {
                cantidadActual -= 1;
                this.m1++;
            }
        }
    }
}
