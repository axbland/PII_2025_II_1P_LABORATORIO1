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
    public partial class JuegoDiario : Form
    {
        public class Jugador
        {
            public string Nombre;
            public int[] Numeros;

            public Jugador(string nombre, int[] numeros)
            {
                Nombre = nombre;
                Numeros = numeros;
            }
        }
        private List<Jugador> jugadores = new List<Jugador>();
        private Random random = new Random();

        public JuegoDiario()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int[] numeros = new int[5];

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe escribir el nombre del comprador.");
                return;
            }

            try
            {
                numeros[0] = int.Parse(txtNumero1.Text);
                numeros[1] = int.Parse(txtNumero2.Text);
                numeros[2] = int.Parse(txtNumero3.Text);
                numeros[3] = int.Parse(txtNumero4.Text);
                numeros[4] = int.Parse(txtNumero5.Text);
            }
            catch
            {
                MessageBox.Show("Todos los números deben ser válidos.");
                return;
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0 || numeros[i] > 100)
                {
                    MessageBox.Show("Todos los números deben estar entre 0 y 100.");
                    return;
                }

                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        MessageBox.Show("No debe repetir números.");
                        return;
                    }
                }
            }

            jugadores.Add(new Jugador(nombre, numeros));

            string mensaje = "Números comprados: ";
            for (int i = 0; i < numeros.Length; i++)
            {
                mensaje += numeros[i];
                if (i < numeros.Length - 1)
                {
                    mensaje += ", ";
                }
            }

            MessageBox.Show(nombre + " compró los números: " + mensaje);

            txtNombre.Clear();
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
            txtNumero4.Clear();
            txtNumero5.Clear();
        }
    }
}
