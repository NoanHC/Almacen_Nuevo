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
            string values = "'" + nombre + "','" + id_marca + "','" + modelo + "'," + parte + "','" + id_factura + "','" + descripcion + "','" + cantidad + "'";
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
            query = "SELECT id_producto as ID, nombre as PRODUCTO, id_marca as IDMARCA, modelo as MODELO, parte as PARTE, descripcion as DESCRIPCION, cantidad as CANTIDAD FROM " + table + " WHERE id_producto='" + id + "'";
            method.Consultar(query, dt);
        }
        public void _consult_Marca(DataTable dt)
        {
            query = "SELECT * FROM `tb_marca`";
            method.Consultar(query, dt);
        }
        public void _consult_Productos(DataTable dt)
        {
            query = "SELECT T_P.id_producto as id, T_P.nombre as Nombre, T_M.marca as Marca, T_P.modelo as Modelo, T_P.parte as Parte, T_P.descripcion as Descripción, T_P.cantidad as Cantidad FROM `tb_productos` as T_P INNER JOIN tb_marca as T_M ON T_P.id_marca = T_M.id_marca";
            method.Consultar(query, dt);
        }
        public bool _delete(string id)
        {
            return method.delete(table, "id_estudiante", id);
        }
    }
}
