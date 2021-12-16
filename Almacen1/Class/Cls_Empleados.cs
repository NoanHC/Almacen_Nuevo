using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Class
{
    class Cls_Empleados
    {
        ClsMethod method = new ClsMethod();
        string table = "tb_empleados";
        string query = "";

        public bool _set(string nombre, string telefono, string correo, string direccion, string puesto, string status, string matricula)
        {
            string campos = "nombre, telefono, correo, direccion, puesto, status , matricula";
            string values = "'" + nombre + "','" + telefono + "','" + correo + "','" + direccion + "','" + puesto + "','" + status + "','" + matricula + "'";
            return method.set(table, campos, values);
        }
        public bool _update(string nombre, string matricula, string direccion, string celular, string id)
        {
            string set = "nombre='" + nombre + "', matricula='" + matricula + "', direccion='" + direccion + "', celular='" + celular + "'";
            return method.update(table, set, "id_estudiante", id);
        }
        public void _get(DataGridView dgv)
        {
            query = "SELECT id_factura_almacen FROM `tb_factura_almacen` ORDER BY id_factura_almacen DESC limit 1";
            method.ExecuteQuery(query, dgv);
        }
        public void _consult_status(DataTable dt)
        {
            query = "SELECT * FROM `tb_status_empleado`";
            method.Consultar(query, dt);
        }
        public bool _delete(string id)
        {
            return method.delete(table, "id_estudiante", id);
        }
    }
}
