using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Class
{
    class Cls_Facturas
    {
        ClsMethod method = new ClsMethod();
        string table = "tb_factura_almacen";
        string query = "";

        public bool _set(string folio_factura, string fecha_compra, string subtotal, string iva, string total)
        {
            string campos = "folio_factura, fecha_compra, subtotal, iva, total";
            string values = "'" + folio_factura + "','" + fecha_compra + "','" + subtotal + "','" + iva + "','" + total + "'";
            return method.set(table, campos, values);
        }
        public bool _update(string nombre, string matricula, string direccion, string celular, string id)
        {
            string set = "nombre='" + nombre + "', matricula='" + matricula + "', direccion='" + direccion + "', celular='" + celular + "'";
            return method.update(table, set, "id_estudiante", id);
        }
        public void _get(DataGridView dgv)
        {
            query = "SELECT id_estudiante as 'Id', nombre as 'Nombre', matricula as 'Matricula', direccion as 'Direccion', celular as 'Celular' FROM tb_estudiante";
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
    }
}
