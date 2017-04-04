using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoObjetosVisual
{
    public partial class Form1 : Form
    {
        private Feriador objFeriador; //Se declara el objeto objferiador
        public Form1()
        {
            InitializeComponent();
            objFeriador = new Feriador(); //Se crea el objeto objferiador dentro del metodo feriador
        }
        
        private void btCalcular_Click(object sender, EventArgs e)
        {
            objFeriador.calcular(Convert.ToInt32(tBCantidad.Text));
            lbB50.Text = "" + objFeriador.ObtenerB50();
            lbM5.Text = "" + objFeriador.ObtenerM5();
            lbM1.Text = "" + objFeriador.ObtenerM1();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
