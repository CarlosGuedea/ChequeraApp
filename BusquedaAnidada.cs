using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlChequesRev2
{
    public partial class BusquedaAnidada : Form
    {
        public BusquedaAnidada()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            BusquedaGeneral busquedaGeneral = new BusquedaGeneral();
            this.Close();
            busquedaGeneral.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int salir;
            if (MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                salir = 1;
                this.Close();
            }
        }
    }
}
