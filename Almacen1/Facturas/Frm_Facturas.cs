using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Facturas
{
    public partial class Frm_Facturas : Form
    {
        // Clases
        Class.Cls_Facturas ObjFacturas = new Class.Cls_Facturas();

        // Variables
        double Subtotal = 0;
        double IVA;
        double Total;
        double Importe = 0;
        public Frm_Facturas()
        {
            InitializeComponent();
        }
        void GuardarFactura()
        {
            DateTime ObjFecha = DateTime.Now;
            string Fecha = ObjFecha.ToString("yyyy-MM-dd HH:mm:ss");
            ObjFacturas._set(txtNoFactura.Text, Fecha, Subtotal.ToString(), IVA.ToString(), Total.ToString());
            //string Id_Factura = ObjFacturas.Id_Factura();
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    ObjFacturas.InsertarDetalleFactura(Id_Factura, dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString(), dataGridView1[3, i].Value.ToString(), dataGridView1[2, i].Value.ToString(), dataGridView1[5, i].Value.ToString(), dataGridView1[4, i].Value.ToString(), dataGridView1[6, i].Value.ToString());
            //}
            dataGridView1.Rows.Clear();
            lblSubtotal.Text = "";
            lblIVA.Text = "";
            lblTotal.Text = "";
            Subtotal = 0;
            IVA = 0;
            Total = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarFactura();
        }
        
        void AgregarProducto()
        {
            Importe = Convert.ToDouble(txtP_Unitario.Text) * Convert.ToDouble(txtCantidad.Text);
            dataGridView1.Rows.Add(cbNombre.Text, txtMarca.Text, txtModelo.Text, txtParte.Text, txtCantidad.Text, Convert.ToDouble(txtP_Unitario.Text).ToString("N2"), Importe);
            Subtotal += Importe;
            lblSubtotal.Text = "SUBTOTAL " + Subtotal.ToString("N2");
            IVA = Subtotal * 0.16;
            lblIVA.Text = "IVA " + IVA.ToString("N2");
            Total = IVA + Subtotal;
            lblTotal.Text = "TOTAL " + Total.ToString("N2");
        }

        private void lklblAgregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarProducto();
        }
    }
}
