using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Class
{
    class Cls_Usuarios
    {
        ClsMethod method = new ClsMethod();
        string table = "tb_usuarios";
        string query = "";

        public bool _set(string usuario, string password, string id_privilegio, string id_empleado)
        {
            string campos = "user, password, id_privilegio, id_empleado";
            string values = "'" + usuario + "','" + password + "','" + id_privilegio + "','" + id_empleado + "'";
            return method.set(table, campos, values);
        }
        public bool _update(string nombre, string matricula, string direccion, string celular, string id)
        {
            string set = "nombre='" + nombre + "', matricula='" + matricula + "', direccion='" + direccion + "', celular='" + celular + "'";
            return method.update(table, set, "id_estudiante", id);
        }
        public void _get(DataGridView dgv)
        {
            query = "SELECT * FROM tb_usuarios";
            method.ExecuteQuery(query, dgv);
        }
        public void _consult(DataTable dt, string id)
        {
            query = "SELECT id_estudiante, nombre, matricula, direccion, celular FROM " + table + " WHERE id_estudiante='" + id + "'";
            method.Consultar(query, dt);
        }
        public bool _delete(string id)
        {
            return method.delete(table, "id_estudiante", id);
        }
        public void _get_select(ComboBox cbx, string table)
        {
            method._get_select_cbx(cbx, table);
        }
    }
}
