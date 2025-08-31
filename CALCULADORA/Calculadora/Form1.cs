using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        // variables
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        double memoria = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void button20_Click(object sender, EventArgs e)
        {
            if (txtScreen.TextLength == 1) txtScreen.Text = "0" ;
            else txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void btn1_Click_Click(object sender, EventArgs e)
        {
            if  (txtScreen.Text == "0" ) txtScreen.Text = "" ;
            txtScreen.Text = txtScreen.Text + "1";
        }

        private void btn2_CLick_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "2";
        }

        private void btn3_Click_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "3";
        }

        private void btn4_Click_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "4";
        }

        private void btn5_Click_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "5";
        }

        private void btn6_Click_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "6";
        }

        private void btn7_Click_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "7";
        }

        private void btn8_Click_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "8";
        }

        private void btn9_Click_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "9";
        }

        private void btn0_Click_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnResta_Click_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnMultiplicacion_Click_Click(object sender, EventArgs e)
        {
            operador = "x";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnDivision_Click_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnIgual_Click_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtScreen.Text);

            switch (operador)
            {
                case "+":
                    txtScreen.Text = $"{num1 + num2}";
                    break;

                case "-":
                    txtScreen.Text = $"{num1 - num2}";
                    break;

                case "x":
                    txtScreen.Text = $"{num1 * num2}";
                    break;

                case "/":
                    txtScreen.Text = $"{num1 / num2}";
                    break;

                case "^":
                    txtScreen.Text = $"{Math.Pow(num1, num2)}";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnRaiz_Click_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScreen.Text))
            {
                double numero = Convert.ToDouble(txtScreen.Text);

                if (numero >= 0)
                {
                    double resultado = Math.Sqrt(numero);
                    txtScreen.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede calcular la raíz de un número negativo",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExponente_Click_Click(object sender, EventArgs e)
        {
            operador = "^"; 
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0"; 
        }

        private void btnLOG_Click_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScreen.Text))
            {
                double numero = Convert.ToDouble(txtScreen.Text);

                if (numero > 0)
                {
                    double resultado = Math.Log10(numero);
                    txtScreen.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("El logaritmo solo está definido para números mayores que 0",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPI_Click_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
                txtScreen.Text = Math.PI.ToString();
            else
                txtScreen.Text += Math.PI.ToString();
        }

        private void btnx10_Click_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScreen.Text))
            {
                double numero = Convert.ToDouble(txtScreen.Text);
                double resultado = numero * 10;
                txtScreen.Text = resultado.ToString();
            }
        }

        private void btnMmas_Click_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScreen.Text))
            {
                double numero = Convert.ToDouble(txtScreen.Text);
                memoria += numero; // sumamos a la memoria
            }
        }

        private void btnMmenos_Click_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScreen.Text))
            {
                double numero = Convert.ToDouble(txtScreen.Text);
                memoria -= numero; // restamos de la memoria
            }
        }

        private void btnMC_Click_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        private void btnMR_Click_Click(object sender, EventArgs e)
        {
            txtScreen.Text = memoria.ToString();
        }

        private void btnPorcentaje_Click_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScreen.Text))
            {
                double numero = Convert.ToDouble(txtScreen.Text);
                txtScreen.Text = (numero / 100).ToString();
            }
        }

        private void btnSen_Click_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScreen.Text))
            {
                double numero = Convert.ToDouble(txtScreen.Text);
                double resultado = Math.Sin(numero * Math.PI / 180); // de grados a radianes
                txtScreen.Text = resultado.ToString();
            }
        }

        private void btnCos_Click_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScreen.Text))
            {
                double numero = Convert.ToDouble(txtScreen.Text);
                double resultado = Math.Cos(numero * Math.PI / 180); // de grados a radianes
                txtScreen.Text = resultado.ToString();
            }
        }

        private void btnTan_Click_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScreen.Text))
            {
                double numero = Convert.ToDouble(txtScreen.Text);

                // Validamos cuando el coseno es 0 para evitar infinito
                if (Math.Cos(numero * Math.PI / 180) == 0)
                {
                    MessageBox.Show("Tangente indefinida en este ángulo",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double resultado = Math.Tan(numero * Math.PI / 180); // de grados a radianes
                    txtScreen.Text = resultado.ToString();
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
