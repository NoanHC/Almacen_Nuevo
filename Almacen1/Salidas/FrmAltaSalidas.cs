using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Salidas
{
    public partial class FrmAltaSalidas : Form
    {
        //Clases
        Class.Cls_Empleados empleados = new Class.Cls_Empleados();
        Class.Cls_Productos productos = new Class.Cls_Productos();
        Class.ClsUtilidades utilidades = new Class.ClsUtilidades();

        //Datatables
        DataTable dt_empleados = new DataTable();
        DataTable dt_productos = new DataTable();

        DataTable dt_datagrid = new DataTable();

        //Variables

        public FrmAltaSalidas()
        {
            InitializeComponent();
        }

        void resta()
        {
            dt_datagrid.Rows.Clear();
            if (dt_datagrid.Columns.Count == 0)
            {
                dt_datagrid.Columns.Add("id_prod", typeof(string));
                dt_datagrid.Columns.Add("prod", typeof(string));
                dt_datagrid.Columns.Add("cant", typeof(string));
            }
            foreach (DataGridViewRow row in dgvEntrada.Rows)
            {
                dt_datagrid.Rows.Add(row.Cells["id_producto"].Value.ToString(), row.Cells["producto"].Value.ToString(), row.Cells["cantidad"].Value.ToString());   
            }

            for (int i = 0; i < dt_datagrid.Rows.Count; i++)
            {
                if (dt_datagrid.Rows[i][0].ToString() == cbx_producto.SelectedValue.ToString())
                {
                    nUD_cantidad.Value = nUD_cantidad.Value - Convert.ToInt16(dt_datagrid.Rows[i][2]);
                }
                //dt_datagrid.Rows[i][1].ToString()
                //MessageBox.Show(dt_datagrid.Rows[i][1].ToString());
            }
        }

        void AgregarProducto()
        {
            cbx_empleado.Enabled = false;
            if (cbx_serie.Text == "NINGUNA")
            {
                dgvEntrada.Rows.Add(cbx_empleado.SelectedValue.ToString(), cbx_empleado.Text, cbx_marca.Text, cbx_producto.SelectedValue.ToString(), cbx_producto.Text, 0, cbx_serie.Text, nUD_cantidad.Value);
            }
            else
            {
                dgvEntrada.Rows.Add(cbx_empleado.SelectedValue.ToString(), cbx_empleado.Text, cbx_marca.Text, cbx_producto.SelectedValue.ToString(), cbx_producto.Text, cbx_serie.SelectedValue.ToString(), cbx_serie.Text, nUD_cantidad.Value);
            }
        }
        void load()
        {
            utilidades._get_select_condicion(cbx_empleado, "tb_empleados", "WHERE id_puesto = 1");
            utilidades._get_select(cbx_marca, "tb_marca");
        }

        private void FrmAltaSalidas_Load(object sender, EventArgs e)
        {
            load();
        }

        private void cbx_producto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string cbx = cbx_serie.Text;
                utilidades._get_select_condicion(cbx_serie, "tb_series", "WHERE id_producto = " + cbx_producto.SelectedValue.ToString());
                if (cbx_serie.Text == cbx)
                {
                    nUD_cantidad.Enabled = true;
                    cbx_serie.Text = "NINGUNA";
                    dt_productos = new DataTable();
                    productos._consult(dt_productos, cbx_producto.SelectedValue.ToString());
                    int cantidad = Convert.ToInt32(dt_productos.Rows[0]["CANTIDAD"].ToString());
                    if (cantidad > 0)
                    {
                        nUD_cantidad.Value = 1;
                        nUD_cantidad.Maximum = cantidad;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void cbx_marca_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                utilidades._get_select_condicion(cbx_producto, "tb_productos", "WHERE id_marca = " + cbx_marca.SelectedValue.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void cbx_serie_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx_serie.Text != "NINGUNA")
                {
                    nUD_cantidad.Enabled = false;
                    nUD_cantidad.Value = 1;

                }
                else
                {
                    nUD_cantidad.Enabled = true;
                    dt_productos = new DataTable();
                    productos._consult(dt_productos, cbx_producto.SelectedValue.ToString());
                    int cantidad = Convert.ToInt32(dt_productos.Rows[0]["CANTIDAD"].ToString());
                    if (cantidad > 0)
                    {
                        nUD_cantidad.Value = 1;
                        nUD_cantidad.Maximum = cantidad;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            resta();
        }
    }
}
