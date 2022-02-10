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
    public partial class Frm_Productos_MAC_Serie : Form
    {
        // Ventanas
        Productos.Frm_Agregar_Serie VentanaSerie;
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
            Id = dtN.Rows[0][0].ToString();
            dtN.Columns.Remove("id");
            dtN.Columns.Remove("Cantidad");
            this.AuxPrimera = AuxPrimera;
            switch (AuxPrimera)
            {
                case 1:
                    PanelSerie.Visible = false;
                    dtN.Columns.Remove("Serie");
                    PanelMAC.Top = 0;
                    break;
                case 2:
                    PanelMAC.Visible = false;
                    dtN.Columns.Remove("MAC");
                    break;
                default:
                    break;
            }
            DGV1.DataSource = dtN;
        }
        public Frm_Productos_MAC_Serie()
        {
            InitializeComponent();
        }

        void AgregarSerie ()
        {
            bool ComprobarSerie = true;
            for (int i = 0; i < DGV1.Rows.Count; i++)
            {
                if (DGV1[4, i].Value.ToString() == "")
                {
                    FilaS = i;
                    break;
                }
            }
            for (int i = 0; i < DGV1.Rows.Count; i++)
            {
                if (txtSerie.Text == DGV1[4,i].Value.ToString())
                {
                    MessageBox.Show("Serie ya agregada");
                    ComprobarSerie = false;
                    break;
                }
            }
            if (ComprobarSerie)
            {
                if (txtSerie.Text != "")
                {
                    ContSerie++;
                }
                DGV1[4, FilaS].Value = txtSerie.Text;
            }
            FilaS++;
        }
        string Codigo_QR()
        {
            Random ObjRandom = new Random();
            string Resultado = "";
            for (int i = 0; i < 8; i++)
            {
                int NumOLet = ObjRandom.Next(0, 2);
                if (NumOLet == 1)
                {
                    Resultado += ObjRandom.Next(9);
                }
                else
                {
                    int aux = ObjRandom.Next(65, 123);
                    while (aux > 90 && aux < 97)
                    {
                        aux = ObjRandom.Next(65, 123);
                    }
                    Resultado += Convert.ToChar(aux);
                }
            }
            return Resultado;
        }
        void Observar()
        {
            switch (AuxPrimera)
            {
                case 1:
                    for (int i = 0; i < DGV1.Rows.Count; i++)
                    {
                        while (true)
                        {
                            Codigo = Codigo_QR();
                            ObjProductos._consult_QR(dtCodigo_QR, Codigo);
                            if (dtCodigo_QR.Rows.Count == 0)
                            {
                                break;
                            }
                        }
                        ObjProductos._set_MAC(DGV1[4, i].Value.ToString(), Id, id_orden_almacen, Codigo);
                    }
                    MessageBox.Show("MAC's registradas");
                    Cerrar();
                    this.Close();
                    break;
                case 2:
                    for (int i = 0; i < DGV1.Rows.Count; i++)
                    {
                        while (true)
                        {
                            Codigo = Codigo_QR();
                            ObjProductos._consult_QR(dtCodigo_QR, Codigo);
                            if (dtCodigo_QR.Rows.Count == 0)
                            {
                                break;
                            }
                        }
                        ObjProductos._set_Serie(DGV1[4, i].Value.ToString(), Id, id_orden_almacen, Codigo);
                    }
                    MessageBox.Show("Series registradas");
                    Cerrar();
                    this.Close();
                    break;
                default:
                    if (ContSerie == DGV1.Rows.Count && ContMAC == DGV1.Rows.Count)
                    {
                        for (int i = 0; i < DGV1.Rows.Count; i++)
                        {
                            while (true)
                            {
                                Codigo = Codigo_QR();
                                ObjProductos._consult_QR(dtCodigo_QR, Codigo);
                                if (dtCodigo_QR.Rows.Count == 0)
                                {
                                    break;
                                }
                            }
                            ObjProductos._set_Serie_MAC(DGV1[4, i].Value.ToString(), DGV1[5, i].Value.ToString(), Id, id_orden_almacen, Codigo);
                        }
                        MessageBox.Show("Series y MAC's registradas");
                        Cerrar();
                        this.Close();
                    }
                    break;
            }
        }
        private void btnAgregarSerie_Click(object sender, EventArgs e)
        {
            if (ContSerie == DGV1.Rows.Count)
            {
                Observar();
            }
            else
            {
                AgregarSerie();
            }
            txtSerie.Focus();
            txtSerie.Text = "";
        }

        void BorrarSerie(int FilaDGV)
        {
            if (MessageBox.Show("¿Desea borrar la serie " + DGV1[4, FilaDGV].Value.ToString() + "?", "Borrar serie", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DGV1[4, FilaDGV].Value = "";
                ContSerie--;
            }
        }

        void BorrarMAC(int FilaDGV)
        {
            if (AuxPrimera == 1)
            {
                if (MessageBox.Show("¿Desea borrar la MAC " + DGV1[4, FilaDGV].Value.ToString() + "?", "Borrar serie", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DGV1[4, FilaDGV].Value = "";
                    ContMAC--;
                }
            }
            else
            {
                if (MessageBox.Show("¿Desea borrar la MAC " + DGV1[5, FilaDGV].Value.ToString() + "?", "Borrar serie", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DGV1[5, FilaDGV].Value = "";
                    ContMAC--;
                }
            }
        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                switch (AuxPrimera)
                {
                    case 1:
                        if (e.ColumnIndex == 4)
                        {
                                MessageBox.Show("MAC");
                                //VentanaSerie = new Frm_Agregar_Serie();
                                //VentanaSerie.ShowDialog();
                        }
                        break;
                    case 2:
                        if (e.ColumnIndex == 4)
                        {
                                MessageBox.Show("Serie");
                                //VentanaSerie = new Frm_Agregar_Serie();
                                //VentanaSerie.ShowDialog();
                        }
                        break;
                    case 3:
                        if (e.ColumnIndex == 4)
                        {
                                MessageBox.Show("Serie");
                                //VentanaSerie = new Frm_Agregar_Serie();
                                //VentanaSerie.ShowDialog();
                        }
                        if (e.ColumnIndex == 5)
                        {
                                MessageBox.Show("MAC");
                        }
                        break;
                    default:
                        break;
                }
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
            if (AuxPrimera == 1)
            {
                bool ComprobarMac = true;
                for (int i = 0; i < DGV1.Rows.Count; i++)
                {
                    if (DGV1[4, i].Value.ToString() == "")
                    {
                        FilaM = i;
                        break;
                    }
                }
                for (int i = 0; i < DGV1.Rows.Count; i++)
                {
                    if (txtMAC.Text == DGV1[4, i].Value.ToString())
                    {
                        MessageBox.Show("MAC ya agregada");
                        ComprobarMac = false;
                        break;
                    }
                }
                if (ComprobarMac)
                {
                    if (txtMAC.Text != "")
                    {
                        ContMAC++;
                    }
                    DGV1[4, FilaM].Value = txtMAC.Text;
                }
                FilaM++;
            }
            else
            {
                bool ComprobarMac = true;
                for (int i = 0; i < DGV1.Rows.Count; i++)
                {
                    if (DGV1[5, i].Value.ToString() == "")
                    {
                        FilaM = i;
                        break;
                    }
                }
                for (int i = 0; i < DGV1.Rows.Count; i++)
                {
                    if (txtMAC.Text == DGV1[5, i].Value.ToString())
                    {
                        MessageBox.Show("MAC ya agregada");
                        ComprobarMac = false;
                        break;
                    }
                }
                if (ComprobarMac)
                {
                    if (txtMAC.Text != "")
                    {
                        ContMAC++;
                    }
                    DGV1[5, FilaM].Value = txtMAC.Text;
                }
                FilaM++;
            }
        }

        private void btnAgregarMAC_Click(object sender, EventArgs e)
        {
            if (ContMAC == DGV1.Rows.Count)
            {
                Observar();
            }
            else
            {
                AgregarMAC();
            }
            txtMAC.Focus();
            txtMAC.Text = "";
        }
    }
}
