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
        class BoletoDiario
        {
            public string Nombre { get; set; }
            public int[] Numeros { get; set; }
        }

        private List<BoletoDiario> listadoDiario = new List<BoletoDiario>();
        private Random random = new Random();

        public frmLoteria()
        {
            InitializeComponent();
        }

        private void frmLoteria_Load(object sender, EventArgs e)
        {

        }

        private void lblNumero1_Click(object sender, EventArgs e)
        {

        }
    }
}
