using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Class
{
    class ClsUtilidades
    {
        //Clases
        ClsMethod method = new ClsMethod();

        public void adaptarFormulario(Form formulario)
        {
            formulario.Location = Screen.PrimaryScreen.WorkingArea.Location;
            formulario.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        public void autocomplete_combobox(ComboBox cbx)
        {
            AutoCompleteStringCollection namec = new AutoCompleteStringCollection();
            for (int i = 0; i < cbx.Items.Count; i++)
            {
                var a = cbx.GetItemText(cbx.Items[i]);
                namec.Add(a);
            }
            cbx.AutoCompleteCustomSource = namec;
            cbx.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public void close()
        {
            System.Windows.Forms.Application.Exit();
        }

        public void _get_select(ComboBox cbx, string table)
        {
            method._get_select_cbx(cbx, table);
        }

        public void _get_select_condicion(ComboBox cbx, string table, string condicion)
        {
            method._get_select_cbx_condicion(cbx, table, condicion);
        }
        public void _Organize_DGV(DataGridView DGV)
        {
            int Ancho = 20;
            for (int i = 0; i < DGV.Columns.Count; i++)
            {
                Ancho += DGV.Columns[i].Width;
            }
            DGV.Width = Ancho;
        }
        public string Codigo_QR(int Cantidad)
        {
            Random ObjRandom = new Random();
            string Resultado = "";
            for (int i = 0; i < Cantidad; i++)
            {
                int NumOLet = ObjRandom.Next(0, 2);
                if (NumOLet == 1)
                {
                    Resultado += ObjRandom.Next(9);
                }
                else
                {
                    int aux = ObjRandom.Next(65, 123);
                    while (aux > 90 && aux < 97)
                    {
                        aux = ObjRandom.Next(65, 123);
                    }
                    Resultado += Convert.ToChar(aux);
                }
            }
            return Resultado;
        }
        public void CentrarComboBox(ComboBox Cb)
        {
            string Texto = "                                                       ";
            int IndexBorrar = Texto.Length - Cb.Text.Length;
            if (IndexBorrar < 0)
            { 
                Texto = Cb.Text;
            }
            else
            {
                Texto = Texto.Substring(0, IndexBorrar);
                Texto += Cb.Text;
            }
            Cb.Text = Texto;
        }
        public string QuitarEspacios(string CbTexto)
        {
            for (int i = 0; i < CbTexto.Length; i++)
            {
                if (CbTexto[i] != ' ')
                {
                    CbTexto = CbTexto.Substring(i, CbTexto.Length - i);
                    break;
                }
            }
            return CbTexto;
        }


    }
}
