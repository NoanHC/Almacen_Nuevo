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
    public partial class Observar_Prueba : Form
    {
        // Clases
        Class.Cls_Registro ObjRegistro = new Class.Cls_Registro();

        // Ventanas
        Frm_Editar_MSF Ventana_MSF;
        Registro.Frm_Codigo_QR Ventana_QR;

        // Datatable
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dtCodigo = new DataTable();

        // Variables
        string id;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Observar_Prueba(DataTable dt, DataTable dtInformacion)
        {
            InitializeComponent();
            this.dt = dt;
            this.dt3 = dtInformacion;
        }

        private void Observar_Prueba_Load(object sender, EventArgs e)
        {
            
            id = dt.Rows[0][0].ToString();
            dt2 = dt.Copy();
            label1.Text = dt2.Rows[0]["Nombre"].ToString();
            label1.Location = new Point((this.Width / 2) - (label1.Width / 2), PanelSuperior.Height);
            dt2.Columns.Remove("Nombre");
            dt2.Columns.Remove("Id");
            dt2.Columns.Remove("Id_SMF");
            lblMarca.Text = "Marca: " + dt3.Rows[0]["Marca"].ToString();
            lblModelo.Text = "Modelo: " + dt3.Rows[0]["Modelo"].ToString();
            lblParte.Text = "Parte: " + dt3.Rows[0]["Parte"].ToString();
            rtxtDescripcion.Text = dt3.Rows[0]["Descripción"].ToString();
            if (dt2.Rows[0]["Serie"].ToString() == "")
            {
                dt2.Columns.Remove("Serie");
            }
            if (dt2.Rows[0]["MAC"].ToString() == "")
            {
                dt2.Columns.Remove("MAC");
            }
            DGV1.DataSource = dt2;
            this.Invoke(new Action(() => DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1));
            this.Invoke(new Action(() => DGV1.Columns["Borrar"].DisplayIndex = DGV1.Columns.Count - 1));
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    PicMedio.BackgroundImage = Properties.Resources.Minimizar;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    PicMedio.BackgroundImage = Properties.Resources.Max_0;
                }
            }
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
