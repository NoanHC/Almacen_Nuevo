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

        // Actions
        public Action Actualizar;
        public Action<DataTable> Producto;

        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();
        Class.ClsUtilidades Utilidades = new Class.ClsUtilidades();

        // datatable
        DataTable dtM = new DataTable();
        DataTable dtF = new DataTable();
        DataTable dtN = new DataTable();
        DataTable dtCodigo_QR = new DataTable();
        DataTable dtNProducto = new DataTable();

        // Variables
        bool NuevoProducto = true;
        string Codigo;

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
            string CbText = Utilidades.QuitarEspacios(cbIds.Text);
            for (int i = 0; i < dtIds.Rows.Count; i++)
            {
                if (CbText == dtIds.Rows[i][1].ToString())
                {
                    ids = dtIds.Rows[i][0].ToString();
                }
            }
            return ids;
        }
        
        void Nuevo()
        {
            ObjProductos._set(txtNombre.Text, Ids(dtM, cbMarca), txtModelo.Text, txtParte.Text, txtDescripcion.Text, txtCantidad.Text);
            Actualizar();
        }
        void SeriesYMACs()
        {
            string Id_Orden = Ids(dtF, cbFactura);
            dtN.Columns.Clear();
            dtN.Rows.Clear();
            ObjProductos._consult_Productos_Ultimo(dtN);
            dtN.Columns.Add("Orden");
            dtN.Columns["Orden"].SetOrdinal(dtN.Columns.Count - 2);
            dtN.Rows[0]["Orden"] = Id_Orden;
            for (int i = 0; i < Convert.ToInt32(txtCantidad.Text) - 1; i++)
            {
                dtN.Rows.Add(dtN.Rows[0][0].ToString(), dtN.Rows[0][1].ToString(), dtN.Rows[0][2].ToString() , dtN.Rows[0][3].ToString(), dtN.Rows[0][4].ToString(), dtN.Rows[0][5].ToString(), dtN.Rows[0][6].ToString(), dtN.Rows[0][7].ToString(), Id_Orden, dtN.Rows[0][8].ToString());
            }
            if (!cbxSeries.Checked && !cbxMAC.Checked)
            {
                while (true)
                {
                    Codigo = Utilidades.Codigo_QR(8);
                    ObjProductos._consult_QR(dtCodigo_QR, Codigo);
                    if (dtCodigo_QR.Rows.Count == 0)
                    {
                        break;
                    }
                }
                ObjProductos._set_Orden(dtN.Rows[0][0].ToString(), Id_Orden, Codigo);
            }
            else
            {
                if (cbxMAC.Checked && cbxSeries.Checked)
                {
                    FormaMACYSerie = new Productos.Frm_Productos_MAC_Serie(3, dtN, Id_Orden);
                    FormaMACYSerie.Cerrar = Exit;
                    FormaMACYSerie.ShowDialog();
                }
                else
                {
                    if (cbxMAC.Checked)
                    {
                        FormaMACYSerie = new Productos.Frm_Productos_MAC_Serie(1, dtN, Id_Orden);
                        FormaMACYSerie.Cerrar = Exit;
                        FormaMACYSerie.ShowDialog();
                    }
                    else
                    {
                        if (cbxSeries.Checked)
                        {
                            FormaMACYSerie = new Productos.Frm_Productos_MAC_Serie(2, dtN, Id_Orden);
                            FormaMACYSerie.Cerrar = Exit;
                            FormaMACYSerie.ShowDialog();
                        }
                    }
                }
            }
            
            Reestablecer();
        }
        void Exit()
        {
            this.Close();
        }
        void NuevaMarca ()
        {
            bool AuxMarca = true;
            for (int i = 0; i < dtM.Rows.Count; i++)
            {
                string CbText = Utilidades.QuitarEspacios(cbMarca.Text);
                if (CbText == dtM.Rows[i][1].ToString())
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
        void Reestablecer()
        {
            txtNombre.Text = "";
            cbMarca.Text = "";
            txtModelo.Text = "";
            txtParte.Text = "";
            cbFactura.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            cbxSeries.Checked = false;
            cbxMAC.Checked = false;
        }
        void ComprobarProducto()
        {
            ObjProductos._consult_Comprobar(dtNProducto, txtNombre.Text);
            if (dtNProducto.Rows.Count != 0)
            {
                if (MessageBox.Show("El producto " + txtNombre.Text + " ya esta registrado, ¿desea registrarlo?", "Producto ya registrado", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    NuevoProducto = true;
                }
                else
                {
                    NuevoProducto = false;
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ComprobarProducto();
            if (NuevoProducto)
            {
                NuevaMarca();
                Nuevo();
                SeriesYMACs();
                this.Close();
            }
            else
            {
                Producto(dtNProducto);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMarca_Leave(object sender, EventArgs e)
        {
            Utilidades.CentrarComboBox(cbMarca);
        }

        private void cbFactura_Leave(object sender, EventArgs e)
        {
            Utilidades.CentrarComboBox(cbFactura);
        }

        private void cbFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
