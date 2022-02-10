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
    public partial class Frm_Editar_MSF : Form
    {
        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();

        // Datatable
        DataTable dt = new DataTable();

        // Variables
        string Id;

        public Frm_Editar_MSF(string Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        void Carga ()
        {

        }
        private void Frm_Editar_MSF_Load(object sender, EventArgs e)
        {
            ObjProductos._consult_Productos_SMF(dt, Id);
            txtId.Text = dt.Rows[0]["Id_SMF"].ToString();
            txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
            txtSerie.Text = dt.Rows[0]["Serie"].ToString();
            txtMAC.Text = dt.Rows[0]["MAC"].ToString();
            txtFolio.Text = dt.Rows[0]["Folio"].ToString();
            txtEstatus.Text = dt.Rows[0]["Status"].ToString();
        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
