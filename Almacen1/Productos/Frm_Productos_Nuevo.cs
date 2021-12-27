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
    public partial class Frm_Productos_Nuevo : Form
    {
        // Formas
        Productos.Frm_Productos_MAC_Serie FormaMACYSerie;
        // Delegados
        public Action DelegadoActualizar;

        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();
        Class.ClsUtilidades Utilidades = new Class.ClsUtilidades();

        // datatable
        DataTable dtM = new DataTable();
        DataTable dtF = new DataTable();
        DataTable dtN = new DataTable();
        DataTable dtN2 = new DataTable();


        public Frm_Productos_Nuevo()
        {
            InitializeComponent();
        }

        void Listas(DataTable dt, ComboBox cb, int Caso)
        {
            cb.Items.Clear();
            dt.Clear();
            switch (Caso)
            {
                case 0:
                    ObjProductos._consult_Marca(dt);
                    break;
                case 1:
                    ObjProductos._consult_Factura(dt);
                    break;
                default:
                    break;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        private void Frm_Productos_Nuevo_Load(object sender, EventArgs e)
        {
            Listas(dtM, cbMarca, 0);
            Utilidades.autocomplete_combobox(cbMarca);
            Listas(dtF, cbFactura, 1);
            Utilidades.autocomplete_combobox(cbFactura);
        }

        string Ids(DataTable dtIds, ComboBox cbIds)
        {
            string ids = "";
            for (int i = 0; i < dtIds.Rows.Count; i++)
            {
                if (cbIds.Text == dtIds.Rows[i][1].ToString())
                {
                    ids = dtIds.Rows[i][0].ToString();
                }
            }
            return ids;
        }

        void Nuevo()
        {
            ObjProductos._set(txtNombre.Text, Ids(dtM, cbMarca), txtModelo.Text, txtParte.Text, Ids(dtF, cbFactura), txtDescripcion.Text, txtCantidad.Text);
            DelegadoActualizar();
        }
        void SeriesYMACs ()
        {
            dtN.Columns.Clear();
            dtN.Rows.Clear();
            ObjProductos._consult_Productos_Ultimo(dtN);
            for (int i = 0; i < Convert.ToInt32(txtCantidad.Text) - 1; i++)
            {
                string Pal = dtN.Rows[0][0].ToString();
                dtN.Rows.Add(dtN.Rows[0][0].ToString(), dtN.Rows[0][1].ToString(), dtN.Rows[0][2].ToString(), dtN.Rows[0][3].ToString(), dtN.Rows[0][4].ToString(), dtN.Rows[0][5].ToString(), dtN.Rows[0][6].ToString(), dtN.Rows[0][7].ToString(), dtN.Rows[0][8].ToString(), dtN.Rows[0][9].ToString());
            }
            if (cbxMAC.Checked && cbxSeries.Checked)
            {
                FormaMACYSerie = new Productos.Frm_Productos_MAC_Serie(3, dtN);
                FormaMACYSerie.ShowDialog();
            }
            else
            {
                if (cbxMAC.Checked)
                {
                    FormaMACYSerie = new Productos.Frm_Productos_MAC_Serie(1, dtN);
                    FormaMACYSerie.ShowDialog();
                }
                else
                {
                    if (cbxSeries.Checked)
                    {
                        FormaMACYSerie = new Productos.Frm_Productos_MAC_Serie(2, dtN);
                        FormaMACYSerie.ShowDialog();
                    }
                }
            }
        }
        void NuevaMarca ()
        {
            bool AuxMarca = true;
            for (int i = 0; i < dtM.Rows.Count; i++)
            {
                if (cbMarca.Text == dtM.Rows[i][1].ToString())
                {
                    AuxMarca = false;
                }
            }
            if (AuxMarca)
            {
                if (MessageBox.Show("La marca " + cbMarca.Text + " no esta registrada, ¿desea registrarla?", "Registrar marca", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ObjProductos._set_Marca(cbMarca.Text);
                }
            }
            Listas(dtM, cbMarca, 0);
            Utilidades.autocomplete_combobox(cbMarca);
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            NuevaMarca();
            //Nuevo();
            SeriesYMACs();
        }
    }
}
