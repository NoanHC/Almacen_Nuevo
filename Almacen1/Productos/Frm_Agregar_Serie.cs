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
    public partial class Frm_Agregar_Serie : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Variables
        DataGridView Tabla;
        int Fila, Columna;

        public Frm_Agregar_Serie(DataGridView Tabla, int Fila, int Columna)
        {
            InitializeComponent();
            lblFila.Text = Fila.ToString();
            this.Tabla = Tabla;
            this.Fila = Fila;
            this.Columna = Columna;
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Tabla[Columna, Fila].Value = txtSerie.Text;
            txtSerie.Text = "";
            if (Fila == Tabla.Rows.Count - 1)
            {
                MessageBox.Show("Series llenas");
            }
            else
            {
                this.Fila = Fila + 1;
                lblFila.Text = Fila.ToString();
            }
            txtSerie.Text = Tabla[Columna, Fila].Value.ToString();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Tabla[Columna,Fila].Value = txtSerie.Text;
            txtSerie.Text = "";
            if (Fila == 0)
            {
                MessageBox.Show("No se puede regresar más");
            }
            else
            {
                this.Fila = Fila - 1;
                lblFila.Text = Fila.ToString();
            }
            txtSerie.Text = Tabla[Columna, Fila].Value.ToString();
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
