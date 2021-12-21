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

        public bool _set(string nombre, string telefono, string correo, string direccion, string id_puesto, string status, string matricula)
        {
            string campos = "nombre, telefono, correo, direccion, id_puesto, status , matricula";
            string values = "'" + nombre + "','" + telefono + "','" + correo + "','" + direccion + "','" + id_puesto + "','" + status + "','" + matricula + "'";
            return method.set(table, campos, values);
        }
        public bool _update(string nombre, string telefono, string correo, string direccion, string id_puesto, string status, string matricula, string id)
        {
            string set = "nombre='" + nombre + "', telefono='" + telefono + "', correo='" + correo + "', direccion='" + direccion + "', id_puesto='" + id_puesto + "', status ='" + status + "', matricula='" + matricula + "'";
            return method.update(table, set, "id_empleado ", id);
        }
        public void _get(DataGridView dgv)
        {
            query = "SELECT T_E.id_empleado as id, T_E.nombre as Nombre, T_E.telefono as Telefono, T_E.correo as Correo, T_E.direccion as Dirección, T_E.puesto as Puesto, T_S_E.status_empleado as Estatus, T_E.matricula FROM `tb_empleados` as T_E INNER JOIN tb_status_empleado as T_S_E on T_E.status = T_S_E.id_status_empleado";
            method.ExecuteQuery(query, dgv);
        }
        public void _consult_status(DataTable dt)
        {
            query = "SELECT * FROM `tb_status_empleado`";
            method.Consultar(query, dt);
        }
        public void _consult_Puesto(DataTable dt)
        {
            query = "SELECT * FROM `tb_puesto`";
            method.Consultar(query, dt);
        }
        public void _consult_Empleado(DataTable dt)
        {
            query = "SELECT T_E.id_empleado as id, T_E.nombre as Nombre, T_E.telefono as Telefono, T_E.correo as Correo, T_E.direccion as Dirección, T_P.puesto as Puesto, T_S_E.status_empleado as Estatus, T_E.matricula FROM `tb_empleados` as T_E INNER JOIN tb_status_empleado as T_S_E on T_E.status = T_S_E.id_status_empleado INNER JOIN tb_puesto AS T_P ON T_E.id_puesto = T_P.id_puesto";
            method.Consultar(query, dt);
        }

        public bool _delete(string id)
        {
            return method.delete(table, "id_empleado", id);
        }
    }
}
