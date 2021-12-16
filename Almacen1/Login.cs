using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace Almacen1
{
    public partial class Login : Form
    {
        //Clases
        Class.ClsLogin login = new Class.ClsLogin();

        //Datatables
        DataTable dt = new DataTable();

        //Variables
        public static string user = "";
        public static int id_usuario = 0;
        public static string ciudad = "";
        public static int id_privilegio = 0;
        public static string id_empleado;
        public Login()
        {
            InitializeComponent();
        }
        void login_in()
        {

            login.login(txt_user.Text, txt_pass.Text, dt);
            if (dt.Rows.Count > 0)
            {
                id_privilegio = Convert.ToInt32(dt.Rows[0]["id_privilegio"]);
                id_usuario = Convert.ToInt32(dt.Rows[0]["id_usuario"]);
                user = dt.Rows[0]["user"].ToString();
                Main.Menu_principal menu = new Main.Menu_principal();
                menu.Show();
                this.Hide();
                login.save_location(txt_user.Text, txt_pass.Text, "1");
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrectos");
                txt_pass.Text = "";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login_in();
        }
    }
}
