using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Class
{
    class Cls_Ordenes
    {
        ClsMethod method = new ClsMethod();
        string table = "tb_orden_almacen";
        string query = "";
        string table2 = "tb_orden_detalle_almacen";

        public bool _set(string folio_factura, string fecha_compra)
        {
            string campos = "folio_orden, fecha_compra";
            string values = "'" + folio_factura + "','" + fecha_compra + "'";
            return method.set(table, campos, values);
        }
        public bool _set_detalle(string id_factura_almacen, string nombre, string marca, string parte, string modelo, string cantidad)
        {
            string campos = "id_orden_almacen, nombre, marca, parte, modelo, cantidad";
            string values = "'" + id_factura_almacen + "','" + nombre + "','" + marca + "','" + parte + "','" + modelo + "','" + cantidad + "'";
            return method.set(table2, campos, values);
        }
        public bool _update(string nombre, string matricula, string direccion, string celular, string id)
        {
            string set = "nombre='" + nombre + "', matricula='" + matricula + "', direccion='" + direccion + "', celular='" + celular + "'";
            return method.update(table, set, "id_estudiante", id);
        }
        public void _get(DataGridView dgv)
        {
            query = "SELECT id_orden_almacen FROM `tb_orden_almacen` ORDER BY id_orden_almacen DESC limit 1";
            method.ExecuteQuery(query, dgv);
        }
        public void _consult(DataTable dt)
        {
            query = "SELECT id_orden_almacen FROM `tb_orden_almacen` ORDER BY id_orden_almacen DESC limit 1";
            method.Consultar(query, dt);
        }
        public bool _delete(string id)
        {
            return method.delete(table, "id_estudiante", id);
        }
    }
}
