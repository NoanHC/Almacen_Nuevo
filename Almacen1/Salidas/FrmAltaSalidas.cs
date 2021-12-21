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
        int cantidad_original;
        int cantidad_modificada;
        int cantidad_final;

        public FrmAltaSalidas()
        {
            InitializeComponent();
        }

        void AgregarDatatable()
        {

            if (dt_datagrid.Columns.Count == 0)
            {
                dt_datagrid.Columns.Add("id_emp", typeof(string));
                dt_datagrid.Columns.Add("emp", typeof(string));
                dt_datagrid.Columns.Add("mar", typeof(string));
                dt_datagrid.Columns.Add("id_prod", typeof(string));
                dt_datagrid.Columns.Add("prod", typeof(string));
                dt_datagrid.Columns.Add("id_ser", typeof(string));
                dt_datagrid.Columns.Add("serie", typeof(string));
                dt_datagrid.Columns.Add("cant", typeof(string));
            }


            if (dt_datagrid.Rows.Count > 0)
            {
                string existente = "y";

                for (int i = 0; i < dt_datagrid.Rows.Count; i++)
                {
                    string id = dt_datagrid.Rows[i]["id_prod"].ToString();
                    int cant = Convert.ToInt32(dt_datagrid.Rows[i]["cant"].ToString());

                    if (id == cbx_producto.SelectedValue.ToString())
                    {
                        dt_datagrid.Rows[i]["cant"] = cant + nUD_cantidad.Value;
                        existente = "y";
                        i = dt_datagrid.Rows.Count;
                    }
                    else
                    {
                        existente = "n";
                    }
                }

                if (existente == "n")
                {
                    dt_datagrid.Rows.Add(cbx_empleado.SelectedValue.ToString(), cbx_empleado.Text, cbx_marca.Text, cbx_producto.SelectedValue.ToString(), cbx_producto.Text, "", cbx_serie.Text, nUD_cantidad.Value);
                    existente = "y";
                }

            }

            if (dt_datagrid.Rows.Count == 0)
            {

                if (cbx_serie.SelectedValue == null)
                {
                    dt_datagrid.Rows.Add(cbx_empleado.SelectedValue.ToString(), cbx_empleado.Text, cbx_marca.Text, cbx_producto.SelectedValue.ToString(), cbx_producto.Text, "", cbx_serie.Text, nUD_cantidad.Value);
                }
                else
                {
                    dt_datagrid.Rows.Add(cbx_empleado.SelectedValue.ToString(), cbx_empleado.Text, cbx_marca.Text, cbx_producto.SelectedValue.ToString(), cbx_producto.Text, cbx_serie.SelectedValue.ToString(), cbx_serie.Text, nUD_cantidad.Value);
                }
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
                //Trae series
                string cbx = cbx_serie.Text;
                utilidades._get_select_condicion(cbx_serie, "tb_series", "WHERE id_producto = " + cbx_producto.SelectedValue.ToString());

                if (cbx_serie.Text == cbx)
                {
                    nUD_cantidad.Enabled = true;
                    cbx_serie.Text = "NINGUNA";
                    dt_productos = new DataTable();
                    productos._consult(dt_productos, cbx_producto.SelectedValue.ToString());
                    cantidad_original = Convert.ToInt32(dt_productos.Rows[0]["CANTIDAD"].ToString());
                    if (cantidad_original > 0)
                    {
                        nUD_cantidad.Maximum = cantidad_original;
                        nUD_cantidad.Value = 1;

                        for (int i = 0; i < dt_datagrid.Rows.Count; i++)
                        {
                            if (cbx_producto.SelectedValue.ToString() == dt_datagrid.Rows[i]["id_prod"].ToString())
                            {
                                cantidad_modificada = cantidad_original - Convert.ToInt32(dt_datagrid.Rows[i]["cant"]);
                                //nUD_cantidad.Maximum = cantidad_modificada;
                                if (cantidad_modificada > 0)
                                {
                                    nUD_cantidad.Maximum = cantidad_modificada;
                                    nUD_cantidad.Value = 1;
                                    i = dt_datagrid.Rows.Count;


                                }
                                if (cantidad_modificada == 0)
                                {
                                    nUD_cantidad.Maximum = cantidad_modificada;
                                    nUD_cantidad.Value = 0;

                                    i = dt_datagrid.Rows.Count;
                                }
                            }

                            else
                            {
                                nUD_cantidad.Maximum = cantidad_original;
                                nUD_cantidad.Value = 1;
                                //i = dt_datagrid.Rows.Count;
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {
                //throw;
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarDatatable();
            Asignar();
            resta();
        }

        void Asignar()
        {
            dgvEntrada.DataSource = dt_datagrid;
        }

        void resta()
        {
            cantidad_final = 0;

            for (int i = 0; i < dt_datagrid.Rows.Count; i++)
            {
                if (cbx_producto.SelectedValue.ToString() == dt_datagrid.Rows[i]["id_prod"].ToString())
                {
                    cantidad_final = Convert.ToInt32(dt_datagrid.Rows[i]["cant"].ToString());
                }
            }

            cantidad_modificada = cantidad_original - cantidad_final;

            //ver estos if para cantidad

            if (cantidad_modificada >= 1)
            {
                nUD_cantidad.Value = 1;
                nUD_cantidad.Maximum = cantidad_modificada;
            }
            if (cantidad_modificada == 1)
            {
                nUD_cantidad.Value = 1;
                nUD_cantidad.Maximum = 1;
            }
            if (cantidad_modificada == 0)
            {
                nUD_cantidad.Value = 0;
                nUD_cantidad.Maximum = cantidad_modificada;
            }

        }

        private void cbx_serie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Aqui falta para series
                if (cbx_serie.Text != "NINGUNA")
                {
                    nUD_cantidad.Enabled = false;
                    dt_productos = new DataTable();
                    productos._consult(dt_productos, cbx_producto.SelectedValue.ToString());
                    cantidad_original = Convert.ToInt32(dt_productos.Rows[0]["CANTIDAD"].ToString());
                    for (int i = 0; i < dt_datagrid.Rows.Count; i++)
                    {
                        if (cbx_producto.SelectedValue.ToString() == dt_datagrid.Rows[i]["id_prod"].ToString())
                        {
                            cantidad_modificada = cantidad_original - Convert.ToInt32(dt_datagrid.Rows[i]["cant"]);
                            //nUD_cantidad.Maximum = cantidad_modificada;
                            if (cantidad_modificada > 0)
                            {
                                nUD_cantidad.Value = 1;
                                nUD_cantidad.Maximum = cantidad_modificada;

                            }
                            if (cantidad_modificada == 0)
                            {
                                nUD_cantidad.Value = 0;
                                nUD_cantidad.Maximum = cantidad_modificada;

                                i = dt_datagrid.Rows.Count;
                            }
                        }

                        else
                        {
                            nUD_cantidad.Maximum = cantidad_original;
                            nUD_cantidad.Value = 1;
                            //i = dt_datagrid.Rows.Count;
                        }

                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {

            }
        }

        private void cbx_serie_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (cbx_serie.Text == "NINGUNA")
                {
                    nUD_cantidad.Enabled = true;
                    dt_productos = new DataTable();
                    productos._consult(dt_productos, cbx_producto.SelectedValue.ToString());
                    int cantidad_original = Convert.ToInt32(dt_productos.Rows[0]["CANTIDAD"].ToString());
                    nUD_cantidad.Maximum = cantidad_original;
                    nUD_cantidad.Value = 1;

                    if (cantidad_original > 0)
                    {
                        for (int i = 0; i < dt_datagrid.Rows.Count; i++)
                        {
                            if (cbx_producto.SelectedValue.ToString() == dt_datagrid.Rows[i]["id_prod"].ToString())
                            {
                                cantidad_modificada = cantidad_original - Convert.ToInt32(dt_datagrid.Rows[i]["cant"]);
                                //nUD_cantidad.Maximum = cantidad_modificada;
                                if (cantidad_modificada > 0)
                                {
                                    nUD_cantidad.Value = 1;
                                    nUD_cantidad.Maximum = cantidad_modificada;
                                    i = dt_datagrid.Rows.Count;
                                }
                                if (cantidad_modificada == 0)
                                {
                                    nUD_cantidad.Value = 0;
                                    nUD_cantidad.Maximum = cantidad_modificada;

                                    i = dt_datagrid.Rows.Count;
                                }
                            }

                            else
                            {
                                nUD_cantidad.Maximum = cantidad_original;
                                nUD_cantidad.Value = 1;
                            }

                        }

                    }
                }

            }
            catch (Exception)
            {
                
            }

        }
    }
}

