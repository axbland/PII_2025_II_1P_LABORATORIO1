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
    public partial class JuegoSemanal : Form
    {
        class Comprador
        {
            public string Nombre { get; set; }
            public int Numero1 { get; set; }
            public int Numero2 { get; set; }
        }
        private Random random = new Random();
        List<Comprador> compradoresSemanal = new List<Comprador>();


        public JuegoSemanal()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int numero1, numero2;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe escribir el nombre del comprador.");
                return;
            }

            if (!int.TryParse(txtNumero1.Text, out numero1) || !int.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Debe ingresar dos números válidos.");
                return;
            }

            if (numero1 == numero2)
            {
                MessageBox.Show("Los números deben ser distintos.");
                return;
            }

            if (numero1 < 0 || numero1 > 100 || numero2 < 0 || numero2 > 100)
            {
                MessageBox.Show("Los números deben estar entre 0 y 100.");
                return;
            }

            // Validar que ningún número esté ya vendido
            bool numero1Ocupado = compradoresSemanal.Any(c => c.Numero1 == numero1 || c.Numero2 == numero1);
            bool numero2Ocupado = compradoresSemanal.Any(c => c.Numero1 == numero2 || c.Numero2 == numero2);

            if (numero1Ocupado || numero2Ocupado)
            {
                MessageBox.Show("Uno o ambos números ya fueron vendidos.");
                return;
            }

            compradoresSemanal.Add(new Comprador
            {
                Nombre = nombre,
                Numero1 = numero1,
                Numero2 = numero2
            });

            MessageBox.Show($"{nombre} compró los números {numero1} y {numero2} correctamente.");

            txtNombre.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            int numeroGanador1 = random.Next(0, 101);
            int numeroGanador2 = random.Next(0, 101);

            string mensaje = $"Números ganadores: {numeroGanador1} y {numeroGanador2}\n\n";
            bool huboGanador = false;

            foreach (var comprador in compradoresSemanal)
            {
                if (comprador.Numero1 == numeroGanador1 && comprador.Numero2 == numeroGanador2)
                {
                    mensaje += $"🎉 {comprador.Nombre} gana L.100,000.00 por acertar ambos números en orden.\n";
                    huboGanador = true;
                }
                else if (comprador.Numero1 == numeroGanador1)
                {
                    mensaje += $"🥇 {comprador.Nombre} gana L.10,000.00 por acertar el primer número.\n";
                    huboGanador = true;
                }
                else if (comprador.Numero2 == numeroGanador2)
                {
                    mensaje += $"🥈 {comprador.Nombre} gana L.1,000.00 por acertar el segundo número.\n";
                    huboGanador = true;
                }
            }

            if (!huboGanador)
            {
                mensaje += "No hubo ganadores esta semana.";
            }

            MessageBox.Show(mensaje, "Resultado del Juego Semanal");

        }
    }
}
