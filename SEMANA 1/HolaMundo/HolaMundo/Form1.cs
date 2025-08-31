using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string usuario, clave;
            usuario = ctUsuario.text;
            clave = ctClave.text;
            if (usuario = "admin" && clave = "admin123")
            {
                MessageBox.Show("Bienvenido al sistema" + usuario);

            }
            else {
                MessageBox.Show("Losiento..Datos incorrectos");
                Close();
            }
        }
    }
}
