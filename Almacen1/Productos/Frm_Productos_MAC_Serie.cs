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
    public partial class Frm_Productos_MAC_Serie : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Ventanas
        Productos.Frm_Agregar_Serie VentanaSerie;
        Productos.Frm_Agregar_Mac VentanaMAC;
        Productos.Frm_Modificar_SerieYMAC VentanaModificarMACYSerie;
        // Acciones 
        public Action Cerrar;

        // Class
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();

        // Datatable
        DataTable dt = new DataTable();
        DataTable dtCodigo_QR = new DataTable();

        // Variables
        string Id;
        int FilaS = 0;
        int FilaM = 0;
        int ContSerie = 0;
        int ContMAC = 0;
        int AuxPrimera;
        string id_orden_almacen = "";
        string Codigo;

        public Frm_Productos_MAC_Serie(int AuxPrimera, DataTable dtN, string id_orden_almacen)
        {
            InitializeComponent();
            this.id_orden_almacen = id_orden_almacen;
            lblNombre.Text = dtN.Rows[0][1].ToString();
            PanellblNombre.Width = lblNombre.Width + 5;
            lblMarca2.Text = dtN.Rows[0][2].ToString();
            lblModelo2.Text = dtN.Rows[0][3].ToString();
            lblParte2.Text = dtN.Rows[0][4].ToString();
            rtxDescripcion.Text = dtN.Rows[0][7].ToString();
            lblOrden2.Text = dtN.Rows[0][8].ToString();
            Id = dtN.Rows[0][0].ToString();
            dtN.Columns.Remove("id");
            dtN.Columns.Remove("Cantidad");
            dtN.Columns.Remove("Nombre");
            dtN.Columns.Remove("Marca");
            dtN.Columns.Remove("Modelo");
            dtN.Columns.Remove("Parte");
            dtN.Columns.Remove("Descripción");
            dtN.Columns.Remove("Orden");
            this.AuxPrimera = AuxPrimera;
            switch (AuxPrimera)
            {
                case 1:
                    dtN.Columns.Remove("Serie");
                    break;
                case 2:
                    dtN.Columns.Remove("MAC");
                    break;
                default:
                    break;
            }
            DGV1.DataSource = dtN;
            DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1;
        }
        public Frm_Productos_MAC_Serie()
        {
            InitializeComponent();
        }
        
        //void AgregarSerie ()
        //{
        //    bool ComprobarSerie = true;
        //    for (int i = 0; i < DGV1.Rows.Count; i++)
        //    {
        //        if (DGV1[4, i].Value.ToString() == "")
        //        {
        //            FilaS = i;
        //            break;
        //        }
        //    }
        //    for (int i = 0; i < DGV1.Rows.Count; i++)
        //    {
        //        if (txtSerie.Text == DGV1[4,i].Value.ToString())
        //        {
        //            MessageBox.Show("Serie ya agregada");
        //            ComprobarSerie = false;
        //            break;
        //        }
        //    }
        //    if (ComprobarSerie)
        //    {
        //        if (txtSerie.Text != "")
        //        {
        //            ContSerie++;
        //        }
        //        DGV1[4, FilaS].Value = txtSerie.Text;
        //    }
        //    FilaS++;
        //}
        //string Codigo_QR()
        //{
        //    Random ObjRandom = new Random();
        //    string Resultado = "";
        //    for (int i = 0; i < 8; i++)
        //    {
        //        int NumOLet = ObjRandom.Next(0, 2);
        //        if (NumOLet == 1)
        //        {
        //            Resultado += ObjRandom.Next(9);
        //        }
        //        else
        //        {
        //            int aux = ObjRandom.Next(65, 123);
        //            while (aux > 90 && aux < 97)
        //            {
        //                aux = ObjRandom.Next(65, 123);
        //            }
        //            Resultado += Convert.ToChar(aux);
        //        }
        //    }
        //    return Resultado;
        //}
        //void Observar()
        //{
        //    switch (AuxPrimera)
        //    {
        //        case 1:
        //            for (int i = 0; i < DGV1.Rows.Count; i++)
        //            {
        //                while (true)
        //                {
        //                    Codigo = Codigo_QR();
        //                    ObjProductos._consult_QR(dtCodigo_QR, Codigo);
        //                    if (dtCodigo_QR.Rows.Count == 0)
        //                    {
        //                        break;
        //                    }
        //                }
        //                ObjProductos._set_MAC(DGV1[4, i].Value.ToString(), Id, id_orden_almacen, Codigo);
        //            }
        //            MessageBox.Show("MAC's registradas");
        //            Cerrar();
        //            this.Close();
        //            break;
        //        case 2:
        //            for (int i = 0; i < DGV1.Rows.Count; i++)
        //            {
        //                while (true)
        //                {
        //                    Codigo = Codigo_QR();
        //                    ObjProductos._consult_QR(dtCodigo_QR, Codigo);
        //                    if (dtCodigo_QR.Rows.Count == 0)
        //                    {
        //                        break;
        //                    }
        //                }
        //                ObjProductos._set_Serie(DGV1[4, i].Value.ToString(), Id, id_orden_almacen, Codigo);
        //            }
        //            MessageBox.Show("Series registradas");
        //            Cerrar();
        //            this.Close();
        //            break;
        //        default:
        //            if (ContSerie == DGV1.Rows.Count && ContMAC == DGV1.Rows.Count)
        //            {
        //                for (int i = 0; i < DGV1.Rows.Count; i++)
        //                {
        //                    while (true)
        //                    {
        //                        Codigo = Codigo_QR();
        //                        ObjProductos._consult_QR(dtCodigo_QR, Codigo);
        //                        if (dtCodigo_QR.Rows.Count == 0)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    ObjProductos._set_Serie_MAC(DGV1[4, i].Value.ToString(), DGV1[5, i].Value.ToString(), Id, id_orden_almacen, Codigo);
        //                }
        //                MessageBox.Show("Series y MAC's registradas");
        //                Cerrar();
        //                this.Close();
        //            }
        //            break;
        //    }
        //}
        private void btnAgregarSerie_Click(object sender, EventArgs e)
        {
            //if (ContSerie == DGV1.Rows.Count)
            //{
            //    Observar();
            //}
            //else
            //{
            //    AgregarSerie();
            //}
            //txtSerie.Focus();
            //txtSerie.Text = "";
        }

        void BorrarSerie(int FilaDGV)
        {
            //if (MessageBox.Show("¿Desea borrar la serie " + DGV1[4, FilaDGV].Value.ToString() + "?", "Borrar serie", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            //    DGV1[4, FilaDGV].Value = "";
            //    ContSerie--;
            //}
        }

        void BorrarMAC(int FilaDGV)
        {
            //if (AuxPrimera == 1)
            //{
            //    if (MessageBox.Show("¿Desea borrar la MAC " + DGV1[4, FilaDGV].Value.ToString() + "?", "Borrar serie", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //    {
            //        DGV1[4, FilaDGV].Value = "";
            //        ContMAC--;
            //    }
            //}
            //else
            //{
            //    if (MessageBox.Show("¿Desea borrar la MAC " + DGV1[5, FilaDGV].Value.ToString() + "?", "Borrar serie", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //    {
            //        DGV1[5, FilaDGV].Value = "";
            //        ContMAC--;
            //    }
            //}
        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    VentanaModificarMACYSerie = new Productos.Frm_Modificar_SerieYMAC(DGV1, e.RowIndex, AuxPrimera);
                    VentanaModificarMACYSerie.ShowDialog();
                }
                //switch (AuxPrimera)
                //{
                //    case 1:
                //        if (e.ColumnIndex == 0)
                //        {
                //            VentanaMAC = new Frm_Agregar_Mac();
                //            VentanaMAC.ShowDialog();
                //        }
                //        break;
                //    case 2:
                //        if (e.ColumnIndex == 0)
                //        {
                //            VentanaSerie = new Frm_Agregar_Serie(DGV1, e.RowIndex, e.ColumnIndex);
                //            VentanaSerie.ShowDialog();
                //        }
                //        break;
                //    case 3:
                //        if (e.ColumnIndex == 0)
                //        {
                //            VentanaSerie = new Frm_Agregar_Serie(DGV1, e.RowIndex, e.ColumnIndex);
                //            VentanaSerie.ShowDialog();
                //        }
                //        if (e.ColumnIndex == 1)
                //        {
                //            VentanaMAC = new Frm_Agregar_Mac();
                //            VentanaMAC.ShowDialog();
                //        }
                //        break;
                //    default:
                //        break;
                //}
                //if (AuxPrimera == 1)
                //{
                //    if (e.ColumnIndex == 4)
                //    {
                //        if (DGV1[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                //        {
                //            VentanaSerie = new Frm_Agregar_Serie();
                //            VentanaSerie.ShowDialog();
                //        }
                //    }
                //}
                //else
                //{
                //    if (e.ColumnIndex == 4)
                //    {
                //        if (DGV1[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                //        {
                //            VentanaSerie = new Frm_Agregar_Serie();
                //            VentanaSerie.ShowDialog();
                //        }
                //    }
                //}
                //if (e.ColumnIndex == 5)
                //{
                //    if (DGV1[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                //    {
                //        VentanaSerie = new Frm_Agregar_Serie();
                //        VentanaSerie.ShowDialog();
                //    }
                //}
            }
        }

        void AgregarMAC()
        {
            //if (AuxPrimera == 1)
            //{
            //    bool ComprobarMac = true;
            //    for (int i = 0; i < DGV1.Rows.Count; i++)
            //    {
            //        if (DGV1[4, i].Value.ToString() == "")
            //        {
            //            FilaM = i;
            //            break;
            //        }
            //    }
            //    for (int i = 0; i < DGV1.Rows.Count; i++)
            //    {
            //        if (txtMAC.Text == DGV1[4, i].Value.ToString())
            //        {
            //            MessageBox.Show("MAC ya agregada");
            //            ComprobarMac = false;
            //            break;
            //        }
            //    }
            //    if (ComprobarMac)
            //    {
            //        if (txtMAC.Text != "")
            //        {
            //            ContMAC++;
            //        }
            //        DGV1[4, FilaM].Value = txtMAC.Text;
            //    }
            //    FilaM++;
            //}
            //else
            //{
            //    bool ComprobarMac = true;
            //    for (int i = 0; i < DGV1.Rows.Count; i++)
            //    {
            //        if (DGV1[5, i].Value.ToString() == "")
            //        {
            //            FilaM = i;
            //            break;
            //        }
            //    }
            //    for (int i = 0; i < DGV1.Rows.Count; i++)
            //    {
            //        if (txtMAC.Text == DGV1[5, i].Value.ToString())
            //        {
            //            MessageBox.Show("MAC ya agregada");
            //            ComprobarMac = false;
            //            break;
            //        }
            //    }
            //    if (ComprobarMac)
            //    {
            //        if (txtMAC.Text != "")
            //        {
            //            ContMAC++;
            //        }
            //        DGV1[5, FilaM].Value = txtMAC.Text;
            //    }
            //    FilaM++;
            //}
        }

        private void btnAgregarMAC_Click(object sender, EventArgs e)
        {
            //if (ContMAC == DGV1.Rows.Count)
            //{
            //    Observar();
            //}
            //else
            //{
            //    AgregarMAC();
            //}
            //txtMAC.Focus();
            //txtMAC.Text = "";
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
                PicMedio.BackgroundImage = Properties.Resources.Max_0;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                PicMedio.BackgroundImage = Properties.Resources.Minimizar;
            }
            condicional();
        }

        private void rtxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rtxDescripcion_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            VentanaSerie = new Frm_Agregar_Serie(DGV1, 0, 1);
            VentanaSerie.ShowDialog();
        }

        private void btnMAC_Click(object sender, EventArgs e)
        {
            switch (AuxPrimera)
            {
                case 1:
                    VentanaMAC = new Frm_Agregar_Mac(DGV1, 0, 1);
                    VentanaMAC.ShowDialog();
                    break;
                case 3:
                    VentanaMAC = new Frm_Agregar_Mac(DGV1, 0, 2);
                    VentanaMAC.ShowDialog();
                    break;
                default:
                    break;
            }
        }
        void BDGV1SM()
        {

            int CountDGV1 = DGV1.ColumnHeadersHeight;
            CountDGV1 += DGV1.Rows.GetRowsHeight(0);
            CountDGV1 += DGV1.Rows.GetRowsHeight(0) / DGV1.Rows.Count;
            PanelDGV.Height = CountDGV1;
            btnMAC.Top = PanelDGV.Top + PanelDGV.Height - 10;
            btnSeries.Top = PanelDGV.Top + PanelDGV.Height - 10;
            btnMAC.Left = PanelDGV.Left + DGV1.Columns["Serie"].Width + ((DGV1.Columns["MAC"].Width / 2) - btnMAC.Width / 2);
            btnSeries.Left = PanelDGV.Left + ((DGV1.Columns["Serie"].Width / 2) - btnMAC.Width / 2);
            if (btnSeries.Top + btnSeries.Height >= this.Height || btnMAC.Top + btnMAC.Height >= this.Height)
            {
                if (this.WindowState == FormWindowState.Normal)
                {

                    btnMAC.Location = new Point(728, 220);
                    btnSeries.Location = new Point(10, 220);
                }
                else
                {
                    int Hola = this.Width - btnMAC.Width - 10;
                    btnMAC.Location = new Point(1234, 220);
                    btnSeries.Location = new Point(10, 220);
                }
            }
            if (PanelDGV.Top + PanelDGV.Height >= this.Height)
            {
                PanelDGV.Height = this.Height - PanelDGV.Top - 25;
            }
        }
        void BDGV1S()
        {
            btnMAC.Visible = false;
            int CountDGV1 = DGV1.ColumnHeadersHeight;
            CountDGV1 += DGV1.Rows.GetRowsHeight(0);
            CountDGV1 += DGV1.Rows.GetRowsHeight(0) / DGV1.Rows.Count;
            PanelDGV.Height = CountDGV1;
            btnSeries.Top = PanelDGV.Top + PanelDGV.Height - 10;
            btnSeries.Left = PanelDGV.Left + (DGV1.Columns["Serie"].Width / 2) - (btnSeries.Width / 2);
            if (btnSeries.Top + btnSeries.Height >= this.Height || btnMAC.Top + btnMAC.Height >= this.Height)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    btnSeries.Location = new Point(10, 220);
                }
                else
                {
                    btnSeries.Location = new Point(10, 220);
                }
            }
            if (PanelDGV.Top + PanelDGV.Height >= this.Height)
            {
                PanelDGV.Height = this.Height - PanelDGV.Top - 25;
            }
        }
        void BDGV1M()
        {
            btnSeries.Visible = false;
            int CountDGV1 = DGV1.ColumnHeadersHeight;
            CountDGV1 += DGV1.Rows.GetRowsHeight(0);
            CountDGV1 += DGV1.Rows.GetRowsHeight(0) / DGV1.Rows.Count;
            PanelDGV.Height = CountDGV1;
            btnMAC.Top = PanelDGV.Top + PanelDGV.Height - 10;
            btnMAC.Left = PanelDGV.Left + ((DGV1.Columns["MAC"].Width / 2) - btnMAC.Width / 2);
            if (btnMAC.Top + btnMAC.Height >= this.Height)
            {
                if (this.WindowState == FormWindowState.Normal)
                {

                    btnMAC.Location = new Point(728, 220);
                }
                else
                {
                    btnMAC.Location = new Point(1234, 220);
                }
            }
            if (PanelDGV.Top + PanelDGV.Height >= this.Height)
            {
                PanelDGV.Height = this.Height - PanelDGV.Top - 25;
            }
        }
        void condicional ()
        {
            if (AuxPrimera == 3)
                BDGV1SM();
            if (AuxPrimera == 1)
                BDGV1M();
            if (AuxPrimera == 2)
                BDGV1S();
        }
        private void Frm_Productos_MAC_Serie_Load(object sender, EventArgs e)
        {
            condicional();
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
