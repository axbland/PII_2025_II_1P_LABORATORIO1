using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PII_2025_II_1P_LABORATORIO1
{
    public partial class frmLoteria : Form
    {
        private string[] boletos = new string[101];
        private Random random = new Random();

        public frmLoteria()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreD.Text;
            int numero;

            if (nombre == "")
            {
                MessageBox.Show("Debe escribir el nombre del comprador.");
                return;
            }

            if (int.TryParse(txtNumero.Text, out numero))
            {
                if (numero < 0 || numero > 100)
                {
                    MessageBox.Show("El número debe ser entre 0 y 100.");
                    return;
                }

                if (boletos[numero] != null)
                {
                    MessageBox.Show("El número ya fue vendido");
                    return;
                }

                boletos[numero] = nombre;
                MessageBox.Show(nombre + " compró el número " + numero);

                txtNombreD.Text = "";
                txtNumero.Text = "";
            }
            else
            {
                MessageBox.Show("Escriba un número válido.");
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            int numeroGanador = random.Next(0, 101);

            if (boletos[numeroGanador] != null)
            {
                MessageBox.Show("Ganó L.10,000.00!\n" + boletos[numeroGanador] + " con el número " + numeroGanador);
            }
            else
            {
                MessageBox.Show("El número ganador fue " + numeroGanador);
            }
        }

        private void lblJuegoMensual_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
