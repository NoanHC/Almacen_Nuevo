using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Entradas
{
    public partial class FrmAltaEntrada : Form
    {
        //Clases
        Class.Cls_Empleados empleados = new Class.Cls_Empleados();
        Class.Cls_Productos productos = new Class.Cls_Productos();
        Class.ClsUtilidades utilidades = new Class.ClsUtilidades();

        //Datatables
        DataTable dt_empleados = new DataTable();
        DataTable dt_productos = new DataTable();

        //Variables
        
        public FrmAltaEntrada()
        {
            InitializeComponent();
        }

        void AgregarProducto()
        {
            dgvEntrada.Rows.Add(cbx_empleado.SelectedValue.ToString(), cbx_empleado.Text, cbx_marca.Text, cbx_producto.SelectedValue.ToString(), cbx_producto.Text, cbx_serie.SelectedValue.ToString());
        }
        void load()
        {
            //Cargar combo de empleados
            utilidades._get_select_condicion(cbx_empleado, "tb_empleados", "WHERE id_puesto = 1");
            utilidades._get_select(cbx_marca, "tb_marca");
        }

        private void FrmAltaEntrada_Load(object sender, EventArgs e)
        {
            load();
        }

        private void cbx_producto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                utilidades._get_select_condicion(cbx_serie, "tb_series", "WHERE id_producto = " + cbx_producto.SelectedValue.ToString());
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
    }
}
