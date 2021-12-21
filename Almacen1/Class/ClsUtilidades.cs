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

    }
}
