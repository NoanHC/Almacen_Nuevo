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
        public bool _update(string user, string password, string id_empleado, string id_privilegio, string id_status,string id)
        {
            string set = "user='" + user + "', password='" + password + "', id_empleado='" + id_empleado + "', id_privilegio='" + id_privilegio + "', id_status_usuario='" + id_status + "'";
            return method.update(table, set, "id_usuario", id);
        }
        public bool _update_status_usuario(string id_status, string id)
        {
            string set = "id_status_usuario='" + id_status + "'";
            return method.update(table, set, "id_usuario", id);
        }
        public void _get(DataGridView dgv)
        {
            query = "SELECT tu.id_usuario as ID, tu.user as USER, tu.password as PASSWORD, te.nombre as NOMBRE, tp.privilegio as PRIVILEGIO, tsu.status as STATUS FROM tb_usuarios tu INNER JOIN tb_privilegios tp ON tu.id_privilegio = tp.id_privilegio INNER JOIN tb_empleados te ON tu.id_empleado = te.id_empleado INNER JOIN tb_status_usuario tsu ON tu.id_status_usuario = tsu.id_status_usuario";
            method.ExecuteQuery(query, dgv);
        }
        public void _consult(DataTable dt, string id)
        {
            query = "SELECT tu.id_usuario as ID, tu.user as USER, tu.password as PASSWORD, tu.id_empleado as ID_EMPLEADO, tu.id_privilegio as ID_PRIVILEGIO, tu.id_status_usuario as STATUS FROM tb_usuarios tu INNER JOIN tb_privilegios tp ON tu.id_privilegio = tp.id_privilegio INNER JOIN tb_empleados te ON tu.id_empleado = te.id_empleado WHERE tu.id_usuario ='" + id + "'";
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
