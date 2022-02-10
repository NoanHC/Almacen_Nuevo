using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Registro
{
    public partial class Frm_Historial_Registro : Form
    {
        // Action
        public Action<bool> ActionCerrar;

        // Clases
        Class.Cls_Registro ObjRegistro = new Class.Cls_Registro();
        Class.ClsUtilidades ObjUtilidades = new Class.ClsUtilidades();
        
        // Datatable
        DataTable dtE = new DataTable();
        DataTable dtPP = new DataTable();
        DataTable dtP = new DataTable();
        List<string> ListaCodigos = new List<string>();
        
        // Variables
        public string Codigo_QR_Producto = "";
        public string Codigo_QR_Empleado = "";
                
        public Frm_Historial_Registro()
        {
            InitializeComponent();
            dtP.Columns.Add("Indice");
        }
        bool Repetido(string Codigo)
        {
            for (int i = 0; i < ListaCodigos.Count; i++)
            {
                if (ListaCodigos[i].ToString() == Codigo)
                {
                    MessageBox.Show("Producto ya en fila");
                    return false;
                }
            }
            return true;
        }
        public bool Productos (string Codigo)
        {
            if (Repetido(Codigo))
            {
                int Cond = dtP.Rows.Count;
                ObjRegistro._consult_Producto(dtP, Codigo);
                if (Cond != dtP.Rows.Count)
                {
                    ListaCodigos.Add(Codigo);
                    for (int i = 0; i < dtP.Rows.Count; i++)
                    {
                        dtP.Rows[i]["Indice"] = i + 1;
                    }
                    DGV2.DataSource = dtP;
                    DGV2.Columns["Borrar"].DisplayIndex = DGV2.Columns.Count - 1;
                    return true;
                }
                return false;
            }
            return false;
            
        }
        public bool InfoEmpleado ()
        {
            ObjRegistro._consult_Empleado(dtE, Codigo_QR_Empleado);
            if (dtE.Rows.Count != 0)
            {
                lblNombre.Text += dtE.Rows[0][0].ToString();
                lblMatricula.Text += dtE.Rows[0][1].ToString();
                lblPuesto.Text += dtE.Rows[0][2].ToString();
                ObjRegistro._consult_Producto_Prestamo(dtPP, dtE.Rows[0][0].ToString());
                DGV1.DataSource = dtPP;
                return true;
            }
            else
            {
                Codigo_QR_Empleado = "";
                MessageBox.Show("Empleado no reconocido");
                return false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ActionCerrar(false);
            this.Visible = false;
        }

        private void Frm_Historial_Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActionCerrar(true);
        }

        private void DGV2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    if (MessageBox.Show("¿Desea borrar el producto " + dtP.Rows[e.RowIndex][1].ToString() + "?", "Borrar producto", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        ListaCodigos.Remove(Codigo_QR_Producto);
                        dtP.Rows.RemoveAt(e.RowIndex);
                        for (int i = 0; i < dtP.Rows.Count; i++)
                        {
                            dtP.Rows[i]["Indice"] = i + 1;
                        }
                        DGV2.DataSource = dtP;
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListaCodigos.Count; i++)
            {
                ObjRegistro._update(dtE.Rows[0][3].ToString(), ListaCodigos[i].ToString());
            }
            this.Close();
        }
        private void Frm_Historial_Registro_Load(object sender, EventArgs e)
        {
            ObjUtilidades._Organize_DGV(DGV1);
            ObjUtilidades._Organize_DGV(DGV2);
            PanellblNombre.Width = lblNombre.Width + lblNombre2.Width + 30;
        }
    }
}
