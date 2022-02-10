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
        Class.ClsUtilidades util = new Class.ClsUtilidades();

        //Datatables
        DataTable dt = new DataTable();

        //Variables
        public static string user = "";
        public static int id_usuario = 0;
        public static string ciudad = "";
        public static int id_privilegio = 0;
        public static string id_empleado;
        public static string Empleado;
        public Login()
        {
            InitializeComponent();
        }
        void login_in()
        {
            try
            {

            login.login(txt_user.Text, txt_pass.Text, dt);
            if (dt.Rows.Count > 0)
            {
                id_privilegio = Convert.ToInt32(dt.Rows[0]["id_privilegio"]);
                id_usuario = Convert.ToInt32(dt.Rows[0]["id_usuario"]);
                id_empleado = dt.Rows[0]["id_empleado"].ToString();
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
            catch (Exception)
            {
                MessageBox.Show("Error 001");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login_in();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            util.close();
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    login_in();
                    txt_user.Text = "";
                    txt_pass.Text = "";
                    txt_user.Focus();
                }
                catch (Exception)
                {
                    txt_user.Text = "";
                    txt_pass.Text = "";
                    txt_user.Focus();
                }
            }
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    login_in();
                    txt_user.Text = "";
                    txt_pass.Text = "";
                    txt_user.Focus();
                }
                catch (Exception)
                {
                    txt_user.Text = "";
                    txt_pass.Text = "";
                    txt_user.Focus();
                }
            }
        }
    }
}
