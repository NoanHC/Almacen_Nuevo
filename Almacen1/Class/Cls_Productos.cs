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

        public bool _set(string nombre, string id_marca, string modelo, string parte, string descripcion, string cantidad)
        {
            string campos = "nombre, id_marca, modelo, parte, descripcion, cantidad";
            string values = "'" + nombre + "','" + id_marca + "','" + modelo + "','" + parte + "','" + descripcion + "','" + cantidad + "'";
            return method.set(table, campos, values);
        }
        public bool _set_Serie(string serie, string id_producto, string id_orden_almacen, string codigo_qr)
        {
            string campos = "serie, id_producto, id_orden_almacen, codigo_qr ";
            string values = "'" + serie + "','" + id_producto + "','" + id_orden_almacen + "','" + codigo_qr + "'";
            return method.set("`tb_series_mac`", campos, values);
        }
        public bool _set_MAC(string mac, string id_producto, string id_orden_almacen, string codigo_qr)
        {
            string campos = "mac, id_producto, id_orden_almacen, codigo_qr ";
            string values = "'" + mac + "','" + id_producto + "','" + id_orden_almacen + "','" + codigo_qr + "'";
            return method.set("`tb_series_mac`", campos, values);
        }
        public bool _set_Serie_MAC(string Serie, string MAC, string id_producto, string id_orden_almacen, string codigo_qr)
        {
            string campos = "Serie, mac, id_producto, id_orden_almacen, codigo_qr ";
            string values = "'" + Serie + "','" + MAC + "','" + id_producto + "','" + id_orden_almacen + "','" + codigo_qr + "'";
            return method.set("`tb_series_mac`", campos, values);
        }
        public bool _set_Orden(string id_producto, string id_orden_almacen, string codigo_qr)
        {
            string campos = "id_producto, id_orden_almacen, codigo_qr  ";
            string values = "'" + id_producto + "','" + id_orden_almacen + "','" + codigo_qr + "'";
            return method.set("`tb_series_mac`", campos, values);
        }

        public bool _set_Marca (string marca)
        {
            string campos = "marca";
            string values = "'" + marca + "'";
            return method.set("tb_marca", campos, values);
        }

        public bool _update(string nombre, string id_marca, string modelo, string parte, string descripcion, string id_producto)
        {
            string set = "nombre='" + nombre + "', id_marca='" + id_marca + "', modelo='" + modelo + "', parte='" + parte + "', descripcion='" + descripcion + "'";
            return method.update(table, set, "id_producto", id_producto);
        }
        public bool _update_cantidad(string cantidad, string id_producto)
        {
            string set = "cantidad='" + cantidad + "'";
            return method.update(table, set, "id_producto", id_producto);
        }
        public bool _update_Status(string id_status_producto, string id_producto)
        {
            string set = "id_status_producto='" + id_status_producto + "'";
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
        public void _consult_QR(DataTable dt, string QR)
        {
            query = "SELECT `codigo_qr` FROM `tb_series_mac` WHERE codigo_qr = '" + QR + "'";
            method.Consultar(query, dt);
        }
        public void _consult_MSF(DataTable dt, string id)
        {
            query = "SELECT T_SM.id_serie_mac, T_P.nombre, T_SM.serie, T_SM.mac, T_OA.folio_orden, T_SP.status_producto FROM `tb_series_mac` AS T_SM INNER JOIN tb_productos AS T_P ON T_SM.id_producto = T_P.id_producto INNER JOIN tb_orden_almacen AS T_OA ON T_SM.id_orden_almacen = T_OA.id_orden_almacen INNER JOIN tb_status_producto AS T_SP ON T_SM.id_status_producto = T_SP.id_status_producto WHERE T_SM.id_serie_mac = '" + id + "'";
            method.Consultar(query, dt);
        }
        public void _consult_Comprobar(DataTable dt, string Nombre)
        {
            query = "SELECT T_P.id_producto as id, T_P.nombre, T_M.marca, T_P.modelo, T_P.parte, T_P.descripcion, T_P.cantidad  FROM `tb_productos` AS T_P INNER JOIN tb_marca AS T_M ON T_P.id_marca = T_M.id_marca WHERE T_P.nombre = '" + Nombre + "'";
            method.Consultar(query, dt);
        }
        public void _consult_Buscar(DataTable dt, string Nombre)
        {
            query = "SELECT T_P.id_producto as id, T_P.nombre as Nombre, T_M.marca as Marca, T_P.modelo as Modelo, T_P.parte as Parte, T_P.descripcion as Descripción, T_P.cantidad as Cantidad  FROM `tb_productos` AS T_P INNER JOIN tb_marca AS T_M ON T_P.id_marca = T_M.id_marca WHERE nombre LIKE '%" + Nombre + "%'";
            method.Consultar(query, dt);
        }
        public void _consult_Buscar_MSF(DataTable dt, string Nombre)
        {
            query = "SELECT T_P.id_producto as id, T_P.nombre as Nombre, T_M.marca as Marca, T_P.modelo as Modelo, T_P.parte as Parte, T_P.descripcion as Descripción, T_P.cantidad as Cantidad  FROM `tb_productos` AS T_P INNER JOIN tb_marca AS T_M ON T_P.id_marca = T_M.id_marca WHERE nombre LIKE '%" + Nombre + "%'";
            method.Consultar(query, dt);
        }
        public void _consult_Serie(DataTable dt)
        {
            query = "SELECT id_mac FROM `tb_macs` GROUP BY id_mac DESC LIMIT 1";
            method.Consultar(query, dt);
        }
        public void _consult_Status(DataTable dt)
        {
            query = "SELECT * FROM `tb_status_producto`";
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
            //SELECT T_P.id_producto as id, T_P.nombre as Nombre, T_S_M.serie as Serie, T_S_M.mac as MAC, T_O.folio_orden as Folio, T_S_P.status_producto as Status FROM `tb_productos` as T_P INNER JOIN tb_orden_almacen as T_O on T_P.id_factura = T_O.id_orden_almacen INNER JOIN tb_series_mac as T_S_M ON T_P.id_producto = T_S_M.id_producto INNER JOIN tb_status_producto as T_S_P ON T_P.id_status_producto = T_S_P.id_status_producto GROUP BY T_P.id_producto
            //query = "SELECT T_P.id_producto as id, T_P.nombre as Nombre, T_M.marca as Marca, T_P.modelo as Modelo, T_P.parte as Parte, T_S_M.serie as Serie, T_S_M.mac as MAC, T_O.folio_orden as Folio, T_P.descripcion as Descripción, T_P.cantidad as Cantidad, T_S_P.status_producto as Status FROM `tb_productos` as T_P INNER JOIN tb_marca as T_M ON T_P.id_marca = T_M.id_marca INNER JOIN tb_orden_almacen as T_O on T_P.id_factura = T_O.id_orden_almacen LEFT JOIN tb_series_mac as T_S_M ON T_P.id_producto = T_S_M.id_producto INNER JOIN tb_status_producto as T_S_P ON T_P.id_status_producto = T_S_P.id_status_producto GROUP BY T_P.id_producto";
            query = "SELECT T_P.id_producto as id, T_P.nombre as Nombre, T_M.marca as Marca, T_P.modelo as Modelo, T_P.parte as Parte, T_P.descripcion as Descripción, T_P.cantidad as Cantidad FROM `tb_productos` as T_P INNER JOIN tb_marca as T_M ON T_P.id_marca = T_M.id_marca GROUP BY T_P.id_producto";
            method.Consultar(query, dt);
        }
        public void _consult_Productos_Series_MACs(DataTable dt, string Id)
        {
            query = "SELECT T_S_M.id_serie_mac as Id_SMF, T_P.id_producto as id, T_P.nombre as Nombre, T_S_M.serie as Serie, T_S_M.mac as MAC, T_O.folio_orden as Folio, T_S_P.status_producto as Status FROM `tb_productos` as T_P INNER JOIN tb_series_mac as T_S_M ON T_P.id_producto = T_S_M.id_producto INNER JOIN tb_orden_almacen as T_O on T_S_M.id_orden_almacen = T_O.id_orden_almacen INNER JOIN tb_status_producto as T_S_P ON T_S_M.id_status_producto = T_S_P.id_status_producto WHERE T_P.id_producto = '" + Id + "'";
            method.Consultar(query, dt);
        }
        public void _consult_Productos_SMF(DataTable dt, string Id)
        {
            query = "SELECT T_S_M.id_serie_mac as Id_SMF, T_P.id_producto as id, T_P.nombre as Nombre, T_S_M.serie as Serie, T_S_M.mac as MAC, T_O.folio_orden as Folio, T_S_P.status_producto as Status FROM `tb_productos` as T_P INNER JOIN tb_series_mac as T_S_M ON T_P.id_producto = T_S_M.id_producto INNER JOIN tb_orden_almacen as T_O on T_S_M.id_orden_almacen = T_O.id_orden_almacen INNER JOIN tb_status_producto as T_S_P ON T_S_M.id_status_producto = T_S_P.id_status_producto WHERE T_S_M.id_serie_mac = '" + Id + "'";
            method.Consultar(query, dt);
        }
        public void _consult_Productos_Ultimo(DataTable dt)
        {
            query = "SELECT T_P.id_producto as id, T_P.nombre as Nombre, T_M.marca as Marca, T_P.modelo as Modelo, T_P.parte as Parte, T_S_M.serie as Serie, T_S_M.mac as MAC, T_P.descripcion as Descripción, T_O_A.folio_orden as Orden, T_P.cantidad as Cantidad FROM `tb_productos` as T_P INNER JOIN tb_orden_almacen as T_O_A INNER JOIN tb_marca as T_M ON T_P.id_marca = T_M.id_marca LEFT JOIN tb_series_mac as T_S_M ON T_P.id_producto = T_S_M.id_producto GROUP BY T_P.id_producto DESC, T_S_M.id_serie_mac LIMIT 1";
            method.Consultar(query, dt);
        }
        public void _consult_Producto(DataTable dt, string Id)
        {
            query = "SELECT T_P.id_producto as id, T_P.nombre as Nombre, T_M.marca as Marca, T_P.modelo as Modelo, T_P.parte as Parte, T_P.descripcion as Descripción, T_P.cantidad as Cantidad FROM `tb_productos` as T_P INNER JOIN tb_marca as T_M ON T_P.id_marca = T_M.id_marca WHERE id_producto = " + Id + " GROUP BY T_P.id_producto";
            method.Consultar(query, dt);
        }
        public void _consult_Factura(DataTable dt)
        {
            query = "SELECT id_orden_almacen , folio_orden FROM `tb_orden_almacen`";
            method.Consultar(query, dt);
        }
        public bool _delete(string id_producto)
        {
            return method.delete(table, "id_producto ", id_producto);
        }
    }
}
