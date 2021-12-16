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
    public partial class FrmAlta : Form
    {
        //Clases
        Class.Cls_Usuarios usuarios = new Class.Cls_Usuarios();
        Class.ClsPrivilegios privilegios = new Class.ClsPrivilegios();
        Class.ClsUtilidades util = new Class.ClsUtilidades();
        //Datatables
        //Variables
        public FrmAlta()
        {
            InitializeComponent();
        }

        void load()
        {
            util._get_select(cbx_empleado, "tb_empleados");
            util._get_select(cbx_privilegio, "tb_privilegios");
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
