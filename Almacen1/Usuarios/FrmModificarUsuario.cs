using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Usuarios
{
    public partial class FrmModificarUsuario : Form
    {
        //Clases
        Class.Cls_Usuarios usuarios = new Class.Cls_Usuarios();
        Class.ClsUtilidades util = new Class.ClsUtilidades();

        //Datatables
        DataTable dt = new DataTable();
        //Forms

        //Variables
        string id_usuario;

        public FrmModificarUsuario(string id)
        {
            InitializeComponent();
            id_usuario = id;
        }
        void modificar()
        {
            try
            {
                if (txt_usuario.Text == "" || txt_pass.Text == "" || cbx_empleado.Text == "" || cbx_privilegio.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else
                {
                    usuarios._update(txt_usuario.Text, txt_pass.Text, cbx_empleado.SelectedValue.ToString(), cbx_privilegio.SelectedValue.ToString(), cbx_status.SelectedValue.ToString(), id_usuario);
                    MessageBox.Show("Usuario modificado con éxito.");
                    FrmListadoUsuarios.cambio = "1";
                    this.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar Codigo de Error: UM-002");
            }
        }

        void load()
        {
            try
            {
                util._get_select(cbx_empleado, "tb_empleados");
                util._get_select(cbx_privilegio, "tb_privilegios");
                util._get_select(cbx_status, "tb_status_usuario");

                usuarios._consult(dt, id_usuario);
                txt_usuario.Text = dt.Rows[0]["USER"].ToString();
                txt_pass.Text = dt.Rows[0]["PASSWORD"].ToString();
                cbx_empleado.SelectedValue = dt.Rows[0]["ID_EMPLEADO"].ToString();
                cbx_privilegio.SelectedValue = dt.Rows[0]["ID_PRIVILEGIO"].ToString();
                cbx_status.SelectedValue = dt.Rows[0]["STATUS"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar Codigo de Error: UM-001");
            }
        }

        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificar();
        }
    }
}
