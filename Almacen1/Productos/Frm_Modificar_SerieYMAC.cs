using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Productos
{
    public partial class Frm_Modificar_SerieYMAC : Form
    {
        //Variables
        int Fila;
        DataGridView DGV1;
        public Frm_Modificar_SerieYMAC(DataGridView DGV1, int Fila)
        {
            InitializeComponent();
            this.Fila = Fila;
            this.DGV1 = DGV1;
        }

        private void Frm_Modificar_SerieYMAC_Load(object sender, EventArgs e)
        {
            txtSerie.Text = DGV1[1,Fila].Value.ToString();
            txtMAC.Text = DGV1[2,Fila].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DGV1[1, Fila].Value = txtSerie.Text;
            DGV1[2, Fila].Value = txtMAC.Text;
            this.Close();
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
