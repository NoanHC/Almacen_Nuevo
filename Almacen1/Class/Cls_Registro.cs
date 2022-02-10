using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Almacen1.Class
{
    class Cls_Registro
    {
        ClsMethod method = new ClsMethod();
        string table = "tb_series_mac";
        string query = "";
        public bool _set_Bitacora(string Proceso, string fecha, string id_empleado, string Notas)
        {
            string campos = "Proceso, fecha, id_empleado, Notas";
            string values = "'" + Proceso + "'," + fecha + ",'" + id_empleado + "','" + Notas + "'";
            return method.set("`tb_bitacora`", campos, values);
        }

        public bool _update(string id_empleado, string codigo_qr)
        {
            string set = "id_empleado='" + id_empleado + "'";
            return method.update(table, set, "codigo_qr", codigo_qr);
        }

        public void _consult_QR(DataTable dt, string id)
        {
            query = "SELECT `codigo_qr` FROM `tb_series_mac` WHERE id_serie_mac = '" + id + "'";
            method.Consultar(query, dt);
        }
        public void _consult_Producto(DataTable dt, string Codigo)
        {
            query = "SELECT T_P.nombre as Nombre, T_SMF.codigo_qr as Codigo FROM `tb_series_mac` AS T_SMF INNER JOIN tb_productos AS T_P ON T_SMF.id_producto = T_P.id_producto WHERE T_SMF.codigo_qr = '" + Codigo + "'";
            method.Consultar(query, dt);
        }
        public void _consult_QR_Empleado(DataTable dt, string id)
        {
            query = "SELECT `qr_code` FROM `tb_empleados` WHERE id_empleado = '" + id + "'";
            method.Consultar(query, dt);
        }
        public void _consult_Empleado(DataTable dt, string qr_code)
        {
            query = "SELECT `nombre`, `matricula`, T_P.puesto, T_E.id_empleado FROM `tb_empleados` AS T_E INNER JOIN tb_puesto AS T_P ON T_E.id_puesto = T_P.id_puesto WHERE qr_code = '" + qr_code + "'";
            method.Consultar(query, dt);
        }
        public void _consult_Empleado_Id(DataTable dt, string Id)
        {
            query = "SELECT `nombre`, `matricula`, T_P.puesto, T_E.id_empleado FROM `tb_empleados` AS T_E INNER JOIN tb_puesto AS T_P ON T_E.id_puesto = T_P.id_puesto WHERE id_empleado = '" + Id + "'";
            method.Consultar(query, dt);
        }

        public void _consult_Producto_Prestamo(DataTable dt, string Nombre)
        {
            query = "SELECT ROW_NUMBER() OVER (ORDER by T_SMF.id_serie_mac) AS 'Indice', T_P.nombre as Nombre, T_SMF.codigo_qr as Codigo FROM `tb_series_mac` AS T_SMF INNER JOIN tb_empleados AS T_E ON T_SMF.id_empleado = T_E.id_empleado INNER JOIN tb_productos AS T_P ON T_SMF.id_producto = T_P.id_producto WHERE T_E.nombre = '" + Nombre + "'";
            method.Consultar(query, dt);
        }
        public void _consult_Producto_Registro(DataTable dt, string Codigo)
        {
            query = "SELECT T_SMF.id_empleado, T_P.nombre, T_E.nombre FROM tb_series_mac AS T_SMF INNER JOIN tb_productos as T_P ON T_SMF.id_producto = T_P.id_producto INNER JOIN tb_empleados as T_E ON T_SMF.id_empleado = T_E.id_empleado WHERE codigo_qr = '" + Codigo + "'";
            method.Consultar(query, dt);
        }
    }
}
