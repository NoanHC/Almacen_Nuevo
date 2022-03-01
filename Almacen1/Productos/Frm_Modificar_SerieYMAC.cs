using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Almacen1.Productos
{
    public partial class Frm_Modificar_SerieYMAC : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Variables
        int Fila, AuxPrimera;
        DataGridView DGV1;

        public Frm_Modificar_SerieYMAC(DataGridView DGV1, int Fila, int AuxPrimera)
        {
            InitializeComponent();
            this.Fila = Fila;
            this.DGV1 = DGV1;
            this.AuxPrimera = AuxPrimera;
        }

        private void Frm_Modificar_SerieYMAC_Load(object sender, EventArgs e)
        {
            if (AuxPrimera == 3)
            {
                txtSerie.Text = DGV1[1, Fila].Value.ToString();
                txtMAC.Text = DGV1[2, Fila].Value.ToString();
            }
            if (AuxPrimera == 2)
            {
                txtSerie.Text = DGV1[1, Fila].Value.ToString();
                txtMAC.Visible = false;
                lblMAC.Visible = false;
                btnModificar.Top = lblBarra1.Top + 10;
                lblBarra2.Top = lblBarra1.Top;
            }
            if (AuxPrimera == 1)
            {
                txtMAC.Text = DGV1[1, Fila].Value.ToString();
                txtSerie.Visible = false;
                lblSerie.Visible = false;
                txtMAC.Top = txtSerie.Top;
                lblMAC.Top = txtSerie.Top;
                lblBarra2.Top = lblBarra1.Top;
                btnModificar.Top = lblBarra1.Top + 10;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (AuxPrimera == 3)
            {
                DGV1[1, Fila].Value = txtSerie.Text;
                DGV1[2, Fila].Value = txtMAC.Text;
            }
            if (AuxPrimera == 2)
            {
                DGV1[1, Fila].Value = txtSerie.Text;
            }
            if (AuxPrimera == 1)
            {
                DGV1[1, Fila].Value = txtMAC.Text;
            }
            this.Close();
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
