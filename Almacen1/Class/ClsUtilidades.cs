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
        public void adaptarFormulario(Form formulario)
        {
            formulario.Location = Screen.PrimaryScreen.WorkingArea.Location;
            formulario.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
