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
        public void close()
        {
            System.Windows.Forms.Application.Exit();
        }

        public void _get_select(ComboBox cbx, string table)
        {
            method._get_select_cbx(cbx, table);
        }
    }
}
