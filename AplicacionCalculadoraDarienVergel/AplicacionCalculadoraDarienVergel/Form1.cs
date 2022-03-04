using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCalculadoraDarienVergel
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //declarar variables
            float numero1, numero2, sumar;
            //datos solicitados
            numero1 = float.Parse(txtNumero1.Text);
            numero2 = float.Parse(txtNumero2.Text);
            //operación
            sumar = numero1 + numero2;
            //imprimir
            txtResultado.Text = sumar.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //datos
            float numero1, numero2, resta;
            numero1 = float.Parse(txtNumero1.Text);
            numero2 = float.Parse(txtNumero2.Text);
            //operación
            resta = numero1 - numero2;
            //imprimir
            txtResultado.Text = resta.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //datos
            float numero1, numero2, multiplicar;
            numero1 = float.Parse(txtNumero1.Text);
            numero2 = float.Parse(txtNumero2.Text);
            //operación
            multiplicar = numero1 * numero2;
            //imprimir
            txtResultado.Text = multiplicar.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //datos
            float numero1, numero2, dividir;
            numero1 = float.Parse(txtNumero1.Text);
            numero2 = float.Parse(txtNumero2.Text);
            //operación
            dividir = numero1 / numero2;
            //imprimir
            txtResultado.Text = dividir.ToString();
        }

        private void btnPotencia2_Click(object sender, EventArgs e)
        {
            //datos
            float numero1, numero2, potencia;
            numero1 = float.Parse(txtNumero1.Text);
            //numero2 = float.Parse(txtNumero2.Text);
            //operación
            potencia = numero1 * numero1;
            //imprimir
            txtResultado.Text = potencia.ToString();
        }

        private void btnPotenciaY_Click(object sender, EventArgs e)
        {
            //datos
            int contador=0;
            int numero1, numero2, potenciaN=1;
            numero1 = int.Parse(txtNumero1.Text);
            numero2 = int.Parse(txtNumero2.Text);
            //operación

            for (contador = 1; contador <=numero2; contador++)  
            {
                potenciaN = potenciaN * numero1;
            } 

            //imprimir
            txtResultado.Text = potenciaN.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";
        }

        private void btnNfact_Click(object sender, EventArgs e)
        {
            //datos
            double numero1, factorial=1;
            numero1 = float.Parse(txtNumero1.Text);

            //operación

            while (numero1 != 0)
            {
                factorial = factorial * numero1; numero1--;
            }
            
            //imprimir
            txtResultado.Text = factorial.ToString();
        }
    }
}
