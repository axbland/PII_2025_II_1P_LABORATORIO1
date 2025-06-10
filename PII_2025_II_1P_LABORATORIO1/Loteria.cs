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
        // Venta diaria
        List<BoletoDiario> boletosDiario = new List<BoletoDiario>();
        public class BoletoDiario
        {
            public string Nombre;
            public int[] Numeros;
        }

        private void VenderDiario()
        {
            string nombre = txtNombreD.Text;
            string num1Text = txtNum1D.Text;
            string num2Text = txtNum2D.Text;
            string num3Text = txtNum3D.Text;
            string num4Text = txtNum4D.Text;
            string num5Text = txtNum5D.Text;

            if (nombre == "")
            {
                MessageBox.Show("Escriba un nombre");
                return;
            }

            int numero1, numero2, numero3, numero4, numero5;

            try
            {
                numero1 = Convert.ToInt32(num1Text);
                numero2 = Convert.ToInt32(num2Text);
                numero3 = Convert.ToInt32(num3Text);
                numero4 = Convert.ToInt32(num4Text);
                numero5 = Convert.ToInt32(num5Text);
            }
            catch
            {
                MessageBox.Show("Los números deben ser enteros.");
                return;
            }

            if (numero1 < 0 || numero1 > 100 ||
                numero2 < 0 || numero2 > 100 ||
                numero3 < 0 || numero3 > 100 ||
                numero4 < 0 || numero4 > 100 ||
                numero5 < 0 || numero5 > 100)
            {
                MessageBox.Show("Número fuera de juego.");
                return;
            }

            if (numero1 == numero2 || numero1 == numero3 || numero1 == numero4 || numero1 == numero5 ||
                numero2 == numero3 || numero2 == numero4 || numero2 == numero5 ||
                numero3 == numero4 || numero3 == numero5 ||
                numero4 == numero5)
            {
                MessageBox.Show("Los números no pueden ser iguales.");
                return;
            }

            int[] numeros = new int[5];
            numeros[0] = numero1;
            numeros[1] = numero2;
            numeros[2] = numero3;
            numeros[3] = numero4;
            numeros[4] = numero5;

            BoletoDiario boleto = new BoletoDiario();
            boleto.Nombre = nombre;
            boleto.Numeros = numeros;

            boletosDiario.Add(boleto);

            MessageBox.Show("Boleto vendido con éxito.");
            MessageBox.Show(nombre + " compró los boletos: " + numero1 + ", " + numero2 + ", " + numero3 + ", " + numero4 + ", " + numero5);

            txtNombreD.Text = "";
            txtNum1D.Text = "";
            txtNum2D.Text = "";
            txtNum3D.Text = "";
            txtNum4D.Text = "";
            txtNum5D.Text = "";
        }

        //Juego diario
        private void JugarDiario()
        {
            if (boletosDiario.Count == 0)
            {
                MessageBox.Show("No hay boletos vendidos");
                return;
            }

            Random random = new Random();
            int[] numerosSorteados = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numerosSorteados[i] = random.Next(0, 101);
            }

            string mensaje = "Números sorteados: " +
                    numerosSorteados[0] + ", " +
                    numerosSorteados[1] + ", " +
                    numerosSorteados[2] + ", " +
                    numerosSorteados[3] + ", " +
                    numerosSorteados[4] + "\n\n";

            bool ganadorD = false;

            foreach (BoletoDiario boleto in boletosDiario)
            {
                int aciertos = 0;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (boleto.Numeros[i] == numerosSorteados[j])
                        {
                            aciertos++;
                            break;
                        }
                    }
                }

                if (aciertos >= 3)
                {
                    ganadorD = true;
                    decimal premio = 0m;

                    if (aciertos == 3)
                    {
                        premio = 5000m;
                    }
                    else if (aciertos == 4)
                    {
                        premio = 10000m;
                    }
                    else if (aciertos == 5)
                    {
                        premio = 100000m;
                    }

                    mensaje += "Ganador: " + boleto.Nombre + "\t Aciertos: " + aciertos + "\t Premio: " + premio + "\n";
                }
            }

            if (!ganadorD)
            {
                mensaje += "No hubo ganadores";
            }

            MessageBox.Show(mensaje);
        }

        // Venta semanal
        List<BoletoSemanal> boletosSemanal = new List<BoletoSemanal>();

        class BoletoSemanal
        {
            public string Nombre;
            public int Numero1;
            public int Numero2;
        }

        private void VenderSemanal()
        {
            string nombre = txtNombreS.Text; 
            string num1Text = txtNum1S.Text;
            string num2Text = txtNum2S.Text; 

            if (nombre == "")
            {
                MessageBox.Show("Escriba un nombre");
                return;
            }

            int numero1, numero2;

            try
            {
                numero1 = Convert.ToInt32(num1Text);
                numero2 = Convert.ToInt32(num2Text);
            }
            catch
            {
                MessageBox.Show("Los números deben ser enteros");
                return;
            }

            if (numero1 < 0 || numero1 > 100 || numero2 < 0 || numero2 > 100)
            {
                MessageBox.Show("Número fuera de juego");
                return;
            }

            if (numero1 == numero2)
            {
                MessageBox.Show("Los números no pueden ser iguales");
                return;
            }

            for (int i = 0; i < boletosSemanal.Count; i++)
            {
                if (boletosSemanal[i].Numero1 == numero1 || boletosSemanal[i].Numero2 == numero1 ||
                    boletosSemanal[i].Numero1 == numero2 || boletosSemanal[i].Numero2 == numero2)
                {
                    MessageBox.Show("Alguno de los números ya fue vendido");
                    return;
                }
            }

            /*
            for (int i = 0; i < boletosSemanal.Count; i++)
            {
                if (boletosSemanal[i].Nombre == nombre)
                {
                    MessageBox.Show("Esta persona ya compró boletos");
                    return;
                }
            }
            */

            BoletoSemanal nuevo = new BoletoSemanal();
            nuevo.Nombre = nombre;
            nuevo.Numero1 = numero1;
            nuevo.Numero2 = numero2;
            boletosSemanal.Add(nuevo);

            MessageBox.Show(nombre + " compró los números " + numero1 + " y " + numero2);

            txtNombreS.Text = "";
            txtNum1S.Text = "";
            txtNum2S.Text = "";
        }

        // Juego semanal
        private void JugarSemanal()
        {
            if (boletosSemanal.Count == 0)
            {
                MessageBox.Show("No hay boletos vendidos");
                return;
            }

            Random r = new Random();
            int numeroGanador1 = r.Next(0, 101);
            int numeroGanador2 = r.Next(0, 101);

            string mensaje = "Números sorteados: " + numeroGanador1 + " y " + numeroGanador2 + "\n";
            bool ganadorS = false;

            for (int i = 0; i < boletosSemanal.Count; i++)
            {
                BoletoSemanal boleto = boletosSemanal[i];

                bool ganaPrimerNumero = (boleto.Numero1 == numeroGanador1);
                bool ganaSegundoNumero = (boleto.Numero2 == numeroGanador2);

                if (ganaPrimerNumero && ganaSegundoNumero)
                {
                    mensaje += "Ganador: " + boleto.Nombre + " Premio: L.100,000\n";
                    ganadorS = true;
                }
                else if (ganaPrimerNumero)
                {
                    mensaje += "Ganador: " + boleto.Nombre + " Premio: L.10,000\n";
                    ganadorS = true;
                }
                else if (ganaSegundoNumero)
                {
                    mensaje += "Ganador: " + boleto.Nombre + " Premio: L.1,000\n";
                    ganadorS = true;
                }
            }

            if (!ganadorS)
            {
                mensaje += "No hubo ganadores.";
            }

            MessageBox.Show(mensaje);
        }

        // Venta mensual

        private string[] boletosMensual = new string[101];

        private void VenderMensual()
        {
            string nombre = txtNombreM.Text; 
            string numTexto = txtNumeroM.Text;
            int numero;

            if (nombre == "")
            {
                MessageBox.Show("Escriba un nombre");
                return;
            }

            try
            {
                numero = Convert.ToInt32(numTexto);
            }
            catch
            {
                MessageBox.Show("Los números deben ser enteros");
                return;
            }

            if (numero < 0 || numero > 100)
            {
                MessageBox.Show("Número fuera de juego");
                return;
            }

            if (boletosMensual[numero] != null)
            {
                MessageBox.Show("El número ya fue vendido");
                return;
            }

            boletosMensual[numero] = nombre;
            MessageBox.Show(nombre + " compró el número " + numero);

            txtNombreM.Text = "";
            txtNumeroM.Text = "";
        }

        // Juego mensual

        private void JugarMensual()
        {
            Random random = new Random();
            int numeroGanador = random.Next(0, 101);

            if (boletosMensual[numeroGanador] != null)
            {
                MessageBox.Show("Ganador: " + boletosMensual[numeroGanador] + " con el número " + numeroGanador + "\nPremio: L.10,000");
            }
            else
            {
                MessageBox.Show("Número ganador: " + numeroGanador + ". \nNo hubo ganador.");
            }
        }


        public frmLoteria()
        {
            InitializeComponent();
        }

        private void frmLoteria_Load(object sender, EventArgs e)
        {

        }

        /***************************/
        private void btnVenderD_Click(object sender, EventArgs e)
        {
            VenderDiario();
        }
        private void btnJugarD_Click(object sender, EventArgs e)
        {
            JugarDiario();
        }
        private void btnVenderS_Click(object sender, EventArgs e)
        {
            VenderSemanal();
        }

        private void btnJugarS_Click(object sender, EventArgs e)
        {
            JugarSemanal();
        }
        private void btnVenderM_Click(object sender, EventArgs e)
        {
            VenderMensual();
        }

        private void btnJugarM_Click(object sender, EventArgs e)
        {
            JugarMensual();
        }
        /***************************/
        private void lblNumero1_Click(object sender, EventArgs e)
        {

        }

        private void lblNotaD_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroD_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
