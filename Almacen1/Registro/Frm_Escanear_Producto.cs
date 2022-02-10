using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Almacen1.Registro
{
    public partial class Frm_Escanear_Producto : Form
    {
        // Ventana
        Registro.Frm_Historial_Registro Ventana_HR = new Frm_Historial_Registro();
        Frm_Notas Ventana_Notas = new Frm_Notas();

        // Datatable
        DataTable dtPruebas = new DataTable();

        // Clases
        Class.Cls_Registro ObjRegistro = new Class.Cls_Registro();

        // Variables
        bool Regresar = false;
        string CajaDeTexto = "";

        public Frm_Escanear_Producto()
        {
            InitializeComponent();
        }
        string Escanear()
        {
            string Codigo = "";
            OpenFileDialog ObjAbrir = new OpenFileDialog()
            {
                Filter = "Image png|*.png",
                InitialDirectory = @"D:\"
            };
            if (ObjAbrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image Imagen = Image.FromFile(ObjAbrir.FileName);
                    BarcodeReader br = new BarcodeReader();
                    Codigo = br.Decode((Bitmap)Imagen).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Imagen no aceptada");
                }
            }
            return Codigo;
        }

        private void txtEscanear_KeyPress(object sender, KeyPressEventArgs e)
        {
            CajaDeTexto += e.KeyChar.ToString();
            e.Handled = true;
            if (e.KeyChar == '\r')
            {
                if (Ventana_HR.Codigo_QR_Empleado == "")
                {
                    if (Ventana_HR.Codigo_QR_Producto == "")
                    {
                        CajaDeTexto = CajaDeTexto.Substring(CajaDeTexto.Length - 9, 8);
                        string Prod = CajaDeTexto;
                        dtPruebas.Clear();
                        ObjRegistro._consult_Producto_Registro(dtPruebas, Prod);
                        if (dtPruebas.Rows.Count != 0)
                        {
                            string Id_Empleado = dtPruebas.Rows[0][0].ToString();
                            if (Id_Empleado != "11")
                            {
                                if (MessageBox.Show("¿Desea regresar el producto " + dtPruebas.Rows[0][1].ToString() + "?", "Borrar producto", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                {
                                    Regresar = true;
                                    Ventana_HR.Codigo_QR_Producto = Prod;
                                    lblEscaner.Text = "Escanear QR del empleado";
                                }
                            }
                            else
                            {
                                Ventana_HR.Productos(Prod);
                                Ventana_HR.Codigo_QR_Producto = Prod;
                                if (Ventana_HR.Codigo_QR_Producto != "")
                                {
                                    lblEscaner.Text = "Escanear QR del empleado";
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Producto no reconocido");
                        }
                    }
                    else
                    {
                        CajaDeTexto = CajaDeTexto.Substring(CajaDeTexto.Length - 10, 9);
                        if (Regresar)
                        {
                            ObjRegistro._consult_Empleado_Id(dtPruebas, Login.id_empleado);
                            ObjRegistro._update("11", Ventana_HR.Codigo_QR_Producto);
                            Ventana_HR.Codigo_QR_Empleado = CajaDeTexto;
                            ObjRegistro._consult_Empleado(dtPruebas, Ventana_HR.Codigo_QR_Empleado);
                            lblEscaner.Text = "Escanear QR del producto";
                            Ventana_Notas.ShowDialog();
                            if (dtPruebas.Rows[0][2].ToString() == dtPruebas.Rows[2][1].ToString())
                            {
                                ObjRegistro._set_Bitacora("El empleado " + dtPruebas.Rows[0][2] + " a devuelto el producto " + dtPruebas.Rows[0][1] + " al empleado " + dtPruebas.Rows[1][1], "NOW()", dtPruebas.Rows[0][0].ToString(), Ventana_Notas.Notas);
                            }
                            else
                            {
                                ObjRegistro._set_Bitacora("El empleado " + dtPruebas.Rows[2][1] + " a devuelto el producto " + dtPruebas.Rows[0][1] + " que tenia el empleado " + dtPruebas.Rows[0][2] + " al empleado " + dtPruebas.Rows[1][1], "NOW()", dtPruebas.Rows[0][0].ToString(), Ventana_Notas.Notas);
                            }
                            Ventana_HR.Codigo_QR_Producto = "";
                            Regresar = false;
                            Ventana_HR.Codigo_QR_Empleado = "";
                        }
                        else
                        {
                            Ventana_HR.Codigo_QR_Empleado = CajaDeTexto;
                            if (Ventana_HR.InfoEmpleado())
                            {
                                lblEscaner.Text = "Escanear QR del producto";
                                Ventana_HR.ShowDialog();
                            }
                        }
                    }
                }
                else
                {
                    CajaDeTexto = CajaDeTexto.Substring(CajaDeTexto.Length - 9, 8);
                    string Prod = CajaDeTexto;
                    dtPruebas.Clear();
                    ObjRegistro._consult_Producto_Registro(dtPruebas, Prod);
                    if (dtPruebas.Rows.Count != 0)
                    {
                        string Id_Empleado = dtPruebas.Rows[0][0].ToString();
                        if (Id_Empleado != "11")
                        {
                            MessageBox.Show("Producto no disponible");
                        }
                        else
                        {
                            if (Ventana_HR.Productos(CajaDeTexto))
                            {
                                Ventana_HR.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Producto no reconocido");
                        if (Ventana_HR.Productos(CajaDeTexto))
                        {
                            Ventana_HR.Visible = true;
                        }
                    }
                }
                CajaDeTexto = "";
            }
        }
        void Cerrar(bool AuxBoton)
        {
            if (AuxBoton)
            {
                this.Close();
            }
            else
            {
                btnCancelar.Visible = true;
            }
        }

        private void Frm_Escanear_Producto_Load(object sender, EventArgs e)
        {
            Ventana_HR.ActionCerrar = Cerrar;
            txtEscanear.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = false;
            Ventana_HR.Visible = true;
        }
    }
}
