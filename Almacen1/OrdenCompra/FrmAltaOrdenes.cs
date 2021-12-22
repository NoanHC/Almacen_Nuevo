using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.OrdenCompra
{
    public partial class FrmAltaOrdenes : Form
    {
        // Clases
        Class.Cls_Ordenes ordenes = new Class.Cls_Ordenes();
        //Class.Cls_Facturas_Detalle Obj_Facurtas_Detalle = new Class.Cls_Facturas_Detalle();
        Class.ClsUtilidades utilidades = new Class.ClsUtilidades();
        Class.Cls_Productos productos = new Class.Cls_Productos();

        //Tablas
        DataTable dt = new DataTable();
        DataTable dt_productos = new DataTable();

        // Variables
        double Subtotal = 0;
        double IVA;
        double Total;
        double Importe = 0;
        public FrmAltaOrdenes()
        {
            InitializeComponent();
        }
        void load()
        {
            utilidades._get_select(cbProveedor, "tb_proveedor");
            utilidades._get_select(cbx_marca, "tb_marca");
        }

        void GuardarFactura()
        {
            DateTime ObjFecha = DateTime.Now;
            string Fecha = ObjFecha.ToString("yyyy-MM-dd HH:mm:ss");
            ordenes._set(txtNoFactura.Text, Fecha);
            ordenes._consult(dt);
            for (int i = 0; i < dgv_orden.Rows.Count; i++)
            {
                ordenes._set_detalle(dt.Rows[0][0].ToString(), dgv_orden[0, i].Value.ToString(), dgv_orden[1, i].Value.ToString(), dgv_orden[3, i].Value.ToString(), dgv_orden[2, i].Value.ToString(), dgv_orden[4, i].Value.ToString());
            }
            dgv_orden.Rows.Clear();
            
            Subtotal = 0;
            IVA = 0;
            Total = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarFactura();
        }
        void AgregarProducto()
        {
            dgv_orden.Rows.Add(cbNombre.Text, cbx_marca.Text, txtModelo.Text, txtParte.Text, txtCantidad.Text);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void cbx_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                utilidades._get_select_condicion(cbNombre, "tb_productos", "WHERE id_marca = " + cbx_marca.SelectedValue.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void cbNombre_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                dt_productos = new DataTable();
                productos._consult(dt_productos, cbNombre.SelectedValue.ToString());
                txtModelo.Text = dt_productos.Rows[0]["MODELO"].ToString();
                txtParte.Text = dt_productos.Rows[0]["PARTE"].ToString();
            }
            catch (Exception)
            {

            }
        }
        private void FrmAltaOrdenes_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
