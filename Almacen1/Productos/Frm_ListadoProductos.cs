using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Almacen1.Productos
{
    public partial class Frm_ListadoProductos : Form
    {
        // Formas
        Productos.Frm_Productos_Editar FormaProductosEditar;
        Productos.Frm_Productos_Nuevo FormaProductosNuevo = new Frm_Productos_Nuevo();
        Productos.Frm_Productos__Observar FormaObservar;
        Productos.Observar_Prueba Observar_Prueba;
        Productos.Frm_Borrar_Producto FormaBorrar;

        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();


        // Datatable
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtO1= new DataTable();
        DataTable dtIformacion = new DataTable();

        //Variables
        int Paginas = 0;
        int Filas = 21;
        int Contador2 = 0;
        int Contador = 0;
        bool PrimeraVez = false;
        int SinStock = 0;
        int Porterminar = 0;
        int EnStock = 0;

        public Frm_ListadoProductos()
        {
            InitializeComponent();
        }
        void VerificarCantidad ()
        {
            for (int i = 0; i < DGV1.Rows.Count; i++)
            {
                if (DGV1[7,i].Value.ToString() == "0")
                {
                    DGV1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(250, 113, 130);
                }
                if (Convert.ToInt32(DGV1[7, i].Value.ToString()) <= 5 && Convert.ToInt32(DGV1[7, i].Value.ToString()) > 0)
                {
                    DGV1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(249, 196, 97);
                }
                if (Convert.ToInt32(DGV1[7, i].Value.ToString()) <= 10 && Convert.ToInt32(DGV1[7, i].Value.ToString()) > 5)
                {
                    DGV1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(248, 240, 67);
                }
                if (Convert.ToInt32(DGV1[7, i].Value.ToString()) > 10)
                {
                    DGV1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(142, 242, 143);
                }
            }
        }
        void ActucalizarPagina()
        {
            if (Contador2 > 0 && Paginas == Contador - 1)
            {
                Filas = Contador2;
                DGV1.Rows.Clear();
                DGV1.RowCount = Filas;
            }
            else
            {
                if (Contador == 0)
                {
                    Filas = Contador2;
                    DGV1.Rows.Clear();
                    DGV1.RowCount = Filas;
                }
                else
                {
                    Filas = 21;
                    DGV1.Rows.Clear();
                    DGV1.RowCount = Filas;
                }
            }
            for (int i = 0; i < dt2.Columns.Count; i++)
            {
                for (int j = 0; j < Filas; j++)
                {
                    DGV1[i + 2, j].Value = dt2.Rows[(Paginas * 21) + j][i];
                }
            }
            cbLista.Text = Paginas.ToString();
            VerificarCantidad();
        }
        void CargarCantidadDePaginas()
        {
            cbLista.Items.Clear();
            Contador = dt2.Rows.Count / 21;
            Contador2 = dt2.Rows.Count - (Contador * 21);
            if (Contador2 > 0)
            {
                Contador++;
            }
            for (int i = 0; i < Contador; i++)
            {
                cbLista.Items.Add(i);
            }
        }
        void Stocks ()
        {

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt2.Rows[i][5].ToString() == "0")
                {
                    SinStock++;
                }
                if (Convert.ToInt32(dt2.Rows[i][5].ToString()) <= 10 && Convert.ToInt32(dt2.Rows[i][5].ToString()) > 0)
                {
                    Porterminar++;
                }
                if (Convert.ToInt32(dt2.Rows[i][5].ToString()) > 10)
                {
                    EnStock++;
                }
            }
            lblSNStock.Text = "Sin stock: " + SinStock;
            lblPorTerminar.Text = "Por terminar: " + Porterminar;
            lblStock.Text = "En stock: " + EnStock;
        }
        void Carga()
        {
            dt1.Clear();
            dt2.Clear();
            ObjProductos._consult_Productos(dt1);
            dt2 = dt1.Copy();
            dt2.Columns.Remove("id");
            Stocks();
            CargarCantidadDePaginas();
            cbLista.Text = Paginas.ToString();
            DGV1.RowCount = 21;
            lblTotal.Text = "Productos: " + dt2.Rows.Count;
            if (!PrimeraVez)
            {
                for (int i = 0; i < dt2.Columns.Count; i++)
                {
                    DGV1.Columns.Add(dt2.Columns[i].ColumnName, dt2.Columns[i].ColumnName);
                }
            }
            ActucalizarPagina();
            this.Invoke(new Action(() => DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1));
            this.Invoke(new Action(() => DGV1.Columns["Borrar"].DisplayIndex = DGV1.Columns.Count - 1));
            DGV1.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV1.Columns["Cantidad"].DefaultCellStyle.Font = new Font("Arial Narrow", 11.25f, FontStyle.Bold);
            DGV1.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn Col in DGV1.Columns)
            {
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //Disponibilidad();
        }
        private void Frm_ListadoProductos_Load(object sender, EventArgs e)
        {
            Carga();
            PrimeraVez = true;
        }
        void Producto (DataTable dt)
        {
            dt2 = dt;
            dt1 = dt;
            dt2.Columns.Remove("id");
            DGV1.DataSource = dt2;
            this.Invoke(new Action(() => DGV1.Columns["Borrar"].DisplayIndex = DGV1.Columns.Count - 1));
            this.Invoke(new Action(() => DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1));
        }
        void Nuevo()
        {
            FormaProductosNuevo.Actualizar = Carga;
            FormaProductosNuevo.Producto = Producto;
            FormaProductosNuevo.ShowDialog();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        void EditarEmpleados(int Id)
        {
            FormaProductosEditar = new Productos.Frm_Productos_Editar(Id, dt1);
            FormaProductosEditar.DelegadoActualizar = Carga;
            FormaProductosEditar.ShowDialog();
        }

        void Borrar_Producto(int Fila)
        {
            if (MessageBox.Show("¿Desea borrar el producto " + dt2.Rows[Fila][0].ToString() + "?", "Borrar producto", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ObjProductos._delete(dt1.Rows[Fila][0].ToString());
                string Nose = dt1.Rows[Fila][0].ToString();
            }
            Carga();
        }
        //void Disponibilidad ()
        //{
        //    for (int i = 0; i < DGV1.Rows.Count; i++)
        //    {
        //        switch (DGV1[11, i].Value.ToString())
        //        {
        //            case "Disponible":
        //                this.Invoke(new Action(() => DGV1[11, i].Style.ForeColor = Color.Green));
        //                break;
        //            case "En espera":
        //                this.Invoke(new Action(() => DGV1[11, i].Style.ForeColor = Color.DarkOrange));
        //                break;
        //            default:
        //                this.Invoke(new Action(() => DGV1[11, i].Style.ForeColor = Color.Red));
        //                break;
        //        }
        //    }
        //}
        private void Frm_ListadoProductos_SizeChanged(object sender, EventArgs e)
        {
            //Disponibilidad(); 
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObjProductos._consult_Producto(dtIformacion, dt1.Rows[e.RowIndex]["id"].ToString());
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex > 1)
                {
                    dtO1.Clear();
                    ObjProductos._consult_Productos_Series_MACs(dtO1, dt1.Rows[e.RowIndex + (Paginas * 21)][0].ToString());
                    if (dtO1.Rows.Count != 0)
                    {
                        FormaObservar = new Frm_Productos__Observar(dtO1);
                        FormaObservar.Show();
                        Observar_Prueba = new Observar_Prueba(dtO1, dtIformacion);
                        Observar_Prueba.Show();
                    }
                    else
                    {
                        MessageBox.Show("Este producto no cuenta con serie o MAC");
                    }
                }
                else
                {
                    if (e.ColumnIndex == 0)
                    {
                        EditarEmpleados(e.RowIndex + (Paginas * 22));
                    }
                    if (e.ColumnIndex == 1)
                    {
                        FormaBorrar = new Frm_Borrar_Producto(dt1.Rows[e.RowIndex + (Paginas * 22)][0].ToString(), dt1.Rows[e.RowIndex + (Paginas * 22)][1].ToString());
                        FormaBorrar.ShowDialog();
                        Carga();
                    }
                }
            }
        }
        void Buscar()
        {
            dt1.Clear();
            dt2.Clear();
            ObjProductos._consult_Buscar(dt1, txtBuscar.Text);
            dt2 = dt1.Copy();
            dt2.Columns.Remove("id");
            CargarCantidadDePaginas();
            Paginas = 0;
            cbLista.Text = Paginas.ToString();
            DGV1.RowCount = 22;
            ActucalizarPagina();
            this.Invoke(new Action(() => DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1));
            this.Invoke(new Action(() => DGV1.Columns["Borrar"].DisplayIndex = DGV1.Columns.Count - 1));
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                Carga();
            }
            else
            {
                Buscar();
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            Paginas++;
            if (Paginas < Contador)
            {
                ActucalizarPagina();
            }
            if (Paginas == Contador)
            {
                Paginas--;
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            
            Paginas--;
            if (Paginas > -1)
            {
                ActucalizarPagina();
            }
            if (Paginas == -1)
            {
                Paginas++;
            }
        }

        private void cbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrimeraVez)
            {
                Paginas = Convert.ToInt32(cbLista.Text);
                ActucalizarPagina();
            }
        }

        private void DGV1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void DGV1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void DGV1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void DGV1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void DGV1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void DGV1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                MessageBox.Show("Hola");
            }
        }
    }
}
