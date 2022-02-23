using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Productos
{
    public partial class Frm_Borrar_Producto : Form
    {
        //Clases
        Class.Cls_Productos ClaseProductos = new Class.Cls_Productos();

        //Variables
        string Id;
        
        public Frm_Borrar_Producto(string Id, String Nombre)
        {
            InitializeComponent();
            this.Id = Id;
            txt_usuario.Text = Nombre;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            ClaseProductos._delete(Id);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
