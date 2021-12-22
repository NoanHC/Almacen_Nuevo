using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen1.Class
{
    class ClsEntregas
    {
        ClsMethod method = new ClsMethod();
        string table = "tb_entregas";
        string query = "";

        public bool _set(string cantidad, string id_empleado, string id_producto, string id_serie)
        {
            string campos = "cantidad, id_empleado, id_producto, id_serie";
            string values = "'" + cantidad + "','" + id_empleado + "','" + id_producto + "','" + id_serie + "'";
            return method.set(table, campos, values);
        }
        
    }
}
