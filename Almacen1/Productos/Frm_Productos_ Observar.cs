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
    public partial class Frm_Productos__Observar : Form
    {
        // Clases
        Class.Cls_Registro ObjRegistro = new Class.Cls_Registro();

        // Ventanas
        Frm_Editar_MSF Ventana_MSF;
        Registro.Frm_Codigo_QR Ventana_QR;

        // Datatable
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtCodigo = new DataTable();
        
        // Variables
        string id;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Frm_Productos__Observar(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void Frm_Productos__Observar_Load(object sender, EventArgs e)
        {
            id = dt.Rows[0][0].ToString();
            dt2 = dt.Copy();
            dt2.Columns.Remove("Id");
            dt2.Columns.Remove("Id_SMF");
            DGV1.DataSource = dt2;
            this.Invoke(new Action(() => DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1));
            this.Invoke(new Action(() => DGV1.Columns["Borrar"].DisplayIndex = DGV1.Columns.Count - 1));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        void Borrar_MSF (int Fila)
        {

        }


        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex > 1)
                {
                    dtCodigo.Clear();
                    ObjRegistro._consult_QR(dtCodigo, dt.Rows[e.RowIndex]["Id_SMF"].ToString());
                    string Codigo = dtCodigo.Rows[0][0].ToString();
                    Ventana_QR = new Registro.Frm_Codigo_QR(Codigo);
                    Ventana_QR.ShowDialog();
                }
                else
                {
                    if (e.ColumnIndex == 0)
                    {
                        Ventana_MSF = new Frm_Editar_MSF(id);
                        Ventana_MSF.ShowDialog();
                    }
                    if (e.ColumnIndex == 1)
                    {
                        Borrar_MSF(e.RowIndex);
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicMedio_Click(object sender, EventArgs e)
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
