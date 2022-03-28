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
            lblFila.Text = (Fila + 1).ToString() + "/" + Tabla.Rows.Count.ToString();
            this.Tabla = Tabla;
            this.Fila = Fila;
            this.Columna = Columna;
            txtSerie.Text = Tabla[Columna, Fila].Value.ToString(); 
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool CondiSerie = true;
            for (int i = 0; i < Fila; i++)
            {
                if (Tabla["Serie", i].Value.ToString() == txtSerie.Text)
                {
                    CondiSerie = false;
                }
            }
            if (CondiSerie)
            {
                if (txtSerie.Text == "")
                {
                    lblErrorSerie.Text = "La serie no puede estar vacia.";
                    lblErrorSerie.Visible = true;
                    tmError.Stop();
                    tmError.Start();
                }
                else
                {
                    Tabla[Columna, Fila].Value = txtSerie.Text;
                    txtSerie.Text = "";
                    if (Fila == Tabla.Rows.Count - 1)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Fila++;
                        lblFila.Text = (Fila + 1).ToString() + "/" + Tabla.Rows.Count.ToString();
                    }
                    txtSerie.Text = Tabla[Columna, Fila].Value.ToString();
                }
                txtSerie.Focus();
            }
            else
            {
                lblErrorSerie.Text = "La serie no pude ser repetida.";
                lblErrorSerie.Visible = true;
                tmError.Stop();
                tmError.Start();
            }
            
        }

        private void btnReintentar_Click(object sender, EventArgs e)
        {
            txtSerie.Text = "";
            txtSerie.Focus();
        }

        private void tmError_Tick(object sender, EventArgs e)
        {
            lblErrorSerie.Visible = false;
            tmError.Stop();
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
