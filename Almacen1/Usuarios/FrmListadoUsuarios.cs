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
            dgvUsuarios.Columns.Clear();
            usuarios._get(dgvUsuarios);
            //dgvUsuarios.Columns[0].Visible = false;
            DataGridViewImageColumn btngrid = new DataGridViewImageColumn();
            btngrid.Image = Properties.Resources.editar;
            dgvUsuarios.Columns.Add(btngrid);
            btngrid.HeaderText = "Modificar";
            btngrid.Name = "edit";
            btngrid.ImageLayout = DataGridViewImageCellLayout.Normal;

            DataGridViewImageColumn btngrid2 = new DataGridViewImageColumn();
            btngrid2.Image = Properties.Resources.baja;
            dgvUsuarios.Columns.Add(btngrid2);
            btngrid2.HeaderText = "Baja";
            btngrid2.Name = "delete";
            btngrid2.ImageLayout = DataGridViewImageCellLayout.Normal;


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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_usuario = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();

            if (e.ColumnIndex == dgvUsuarios.Columns["edit"].Index)
            {
                FrmModificarUsuario edit = new FrmModificarUsuario(id_usuario);
                edit.ShowDialog();
            }
            if (e.ColumnIndex == dgvUsuarios.Columns["delete"].Index)
            {
                FrmBajaUsuario delete = new FrmBajaUsuario(id_usuario);
                delete.ShowDialog();
            }
        }

    }
}
