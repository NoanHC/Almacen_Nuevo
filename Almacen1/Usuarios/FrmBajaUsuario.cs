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
    public partial class FrmBajaUsuario : Form
    {
        //Clases
        Class.Cls_Usuarios usuarios = new Class.Cls_Usuarios();
        Class.ClsUtilidades util = new Class.ClsUtilidades();

        //Datatables
        DataTable dt = new DataTable();
        //Forms

        //Variables
        string id_usuario;

        public FrmBajaUsuario(string id)
        {
            InitializeComponent();
            id_usuario = id;
        }

        void baja()
        {
            try
            {
                if (txt_usuario.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else
                {
                    usuarios._update_status_usuario("2", id_usuario);
                    MessageBox.Show("Usuario dado de baja con éxito");
                    FrmListadoUsuarios.cambio = "1";
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar Codigo de Error: UD-002");
            }
        }
        void load()
        {
            try
            {
                usuarios._consult(dt, id_usuario);
                txt_usuario.Text = dt.Rows[0]["USER"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar Codigo de Error: UD-001");
            }
        }

        private void FrmBajaUsuario_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            baja();
        }
    }
}
