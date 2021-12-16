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
    public partial class FrmListadoUsuarios : Form
    {
        //Clases
        Class.Cls_Usuarios usuarios = new Class.Cls_Usuarios();
        //Datatables
        //Formas
        Usuarios.FrmAlta alta = new FrmAlta();
        //Variables
        public static string cambio = "0";
        public FrmListadoUsuarios()
        {
            InitializeComponent();
        }
        void load()
        {
            usuarios._get(dgvUsuarios);
        }
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            alta.ShowDialog();
        }

        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            load();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cambio == "1")
            {
                load();
                cambio = "0";
            }
        }
    }
}
