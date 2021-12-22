using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Class
{
    class Cls_Productos
    {
        ClsMethod method = new ClsMethod();
        string table = "tb_productos";
        string query = "";

        public bool _set(string nombre, string id_marca, string modelo, string parte, string id_factura, string descripcion, string cantidad)
        {
            string campos = "nombre, id_marca , modelo, parte , id_factura , descripcion , cantidad";
            string values = "'" + nombre + "','" + id_marca + "','" + modelo + "','" + parte + "','" + id_factura + "','" + descripcion + "','" + cantidad + "'";
            return method.set(table, campos, values);
        }
        public bool _set_Marca (string marca)
        {
            string campos = "marca";
            string values = "'" + marca + "'";
            return method.set("tb_marca", campos, values);
        }

        public bool _update(string nombre, string id_marca, string modelo, string parte, string id_factura, string descripcion, string cantidad, string id_producto)
        {
            string set = "nombre='" + nombre + "', id_marca='" + id_marca + "', modelo='" + modelo + "', parte='" + parte + "', id_factura='" + id_factura + "', descripcion='" + descripcion + "', cantidad='" + cantidad + "'";
            return method.update(table, set, "id_producto", id_producto);
        }
        public bool _update_cantidad(string cantidad, string id_producto)
        {
            string set = "cantidad='" + cantidad + "'";
            return method.update(table, set, "id_producto", id_producto);
        }
        public void _get(DataGridView dgv)
        {
            query = "SELECT id_estudiante as 'Id', nombre as 'Nombre', matricula as 'Matricula', direccion as 'Direccion', celular as 'Celular' FROM tb_estudiante";
            method.ExecuteQuery(query, dgv);
        }
        public void _consult(DataTable dt, string id)
        {
            query = "SELECT id_producto as ID, nombre as PRODUCTO, id_marca as IDMARCA, modelo as MODELO, parte as PARTE, descripcion as DESCRIPCION, cantidad as CANTIDAD FROM " + table + " WHERE id_producto='" + id + "'";
            method.Consultar(query, dt);
        }
        public void _consult_Marca(DataTable dt)
        {
            query = "SELECT * FROM `tb_marca`";
            method.Consultar(query, dt);
        }
        public void _consult_Modelo(DataTable dt, string id)
        {
            query = "SELECT id_producto, modelo FROM tb_productos WHERE id_producto = " + id;
            method.Consultar(query, dt);
        }
        public void _consult_Productos(DataTable dt)
        {
            query = "SELECT T_P.id_producto as id, T_P.nombre as Nombre, T_M.marca as Marca, T_P.modelo as Modelo, T_P.parte as Parte, T_S.serie as Serie, T_Mac.mac as MAC, T_F.folio_factura as Folio, T_P.descripcion as Descripción, T_P.cantidad as Cantidad FROM `tb_productos` as T_P INNER JOIN tb_marca as T_M ON T_P.id_marca = T_M.id_marca INNER JOIN tb_factura_almacen as T_F on T_P.id_factura = T_F.id_factura_almacen LEFT JOIN tb_series as T_S ON T_P.id_producto = T_S.id_producto LEFT JOIN tb_macs as T_Mac ON T_S.id_serie = T_Mac.id_serie";
            method.Consultar(query, dt);
        }
        public void _consult_Productos_Ultimo(DataTable dt)
        {
            query = "SELECT T_P.id_producto as id, T_P.nombre as Nombre, T_M.marca as Marca, T_P.modelo as Modelo, T_P.parte as Parte, T_S.serie as Serie, T_Mac.mac as MAC, T_F.folio_factura as Folio, T_P.descripcion as Descripción, T_P.cantidad as Cantidad FROM `tb_productos` as T_P INNER JOIN tb_marca as T_M ON T_P.id_marca = T_M.id_marca INNER JOIN tb_factura_almacen as T_F on T_P.id_factura = T_F.id_factura_almacen LEFT JOIN tb_series as T_S ON T_P.id_producto = T_S.id_producto LEFT JOIN tb_macs as T_Mac ON T_S.id_serie = T_Mac.id_serie GROUP BY T_P.id_producto DESC, T_S.id_serie LIMIT 1";
            method.Consultar(query, dt);
        }
        public void _consult_Factura(DataTable dt)
        {
            query = "SELECT id_factura_almacen, folio_factura FROM `tb_factura_almacen`";
            method.Consultar(query, dt);
        }
        public bool _delete(string id_producto)
        {
            return method.delete(table, "id_producto ", id_producto);
        }
    }
}
