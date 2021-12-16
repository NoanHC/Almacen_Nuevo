using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Almacen1.Class
{
    class ClsMethod : ClsConnectionServer
    {
        string query;
        public void get(string table, DataGridView dgv)
        {
            query = "SELECT * FROM " + table;
            ExecuteQuery(query, dgv);
        }
        public bool set(string table, string camps, string values)
        {
            query = "INSERT INTO " + table + "(" + camps + ")VALUES(" + values + ")";
            return ExecuteNonQuery(query);
        }
        public bool update(string table, string setcamps, string camp, string conditon)
        {
            query = "UPDATE " + table + " SET " + setcamps + " WHERE " + camp + "='" + conditon + "'";
            return ExecuteNonQuery(query);
        }
        public bool delete(string table, string camp, string conditon)
        {
            query = "DELETE FROM " + table + " WHERE " + camp + "='" + conditon + "'";
            return ExecuteNonQuery(query);
        }
        public void consult(string table, string conditon, DataGridView dgv)
        {
            query = "SELECT * FROM " + table + " WHERE " + conditon;
            ExecuteQuery(query, dgv);
        }
        public void get_cbx(string table, string name, string id, ComboBox cbx)
        {
            query = "SELECT * FROM " + table;
            ExecuteQueryCbx(query, name, id, cbx);
        }
        public void get_cbx_condition(string table, string name, string id, ComboBox cbx, string condition)
        {
            query = "SELECT * FROM " + table + " " + condition;
            ExecuteQueryCbx(query, name, id, cbx);
        }


        public void get_cbx_condition_camp_concatenacion(ComboBox cbx, string table, string condition)
        {
            string[] datos = set_select(table);
            string query = "SELECT " + datos[0] + "," + datos[1] + " FROM " + table + " " + condition;
            string[] data = datos[0].Split(' ');
            ExecuteQueryCbx(query, data[2], datos[1], cbx);
        }

        public void _get_select_cbx_condition(ComboBox cbx, string table, string condition)
        {
            string[] datos = set_select(table);
            get_cbx_condition(table, datos[0], datos[1], cbx, condition);
        }



        public bool DarBaja(string table, string setcamps, string camp, string conditon)
        {
            query = "UPDATE " + table + " SET " + setcamps + " WHERE " + camp + "='" + conditon + "'";
            return ExecuteNonQuery(query);
        }
        public string format_fecha(string fecha)
        {
            if (fecha.Length == 9)
            {
                fecha = fecha.Substring(5, 4) + "/0" + fecha.Substring(0, 2) + fecha.Substring(2, 2);
            }
            else if (fecha.Length == 8)
            {
                fecha = fecha.Substring(4, 4) + "/0" + fecha.Substring(0, 2) + "0" + fecha.Substring(2, 1);
            }
            else
            {
                fecha = fecha.Substring(6, 4) + "/" + fecha.Substring(0, 3) + fecha.Substring(3, 2);
            }
            return fecha;
        }

        private string[] set_select(string table)
        {
            string[] datos = new string[2];
            switch (table)
            {
                case "tb_estado":
                    datos[0] = "estado";
                    datos[1] = "id_estado";
                    break;
                case "tb_colonia":
                    datos[0] = "colonia";
                    datos[1] = "id_colonia";
                    break;
                case "tb_municipio":
                    datos[0] = "municipio";
                    datos[1] = "id_municipio";
                    break;
                case "tb_privilegios":
                    datos[0] = "privilegio";
                    datos[1] = "id_privilegio";
                    break;
                case "tb_status":
                    datos[0] = "status";
                    datos[1] = "id_status";
                    break;
                case "tb_tipocliente":
                    datos[0] = "tipo";
                    datos[1] = "id_tipo";
                    break;
                case "tb_tipoisn":
                    datos[0] = "meses";
                    datos[1] = "id_tipo";
                    break;
                case "tb_tipopago":
                    datos[0] = "tipopago";
                    datos[1] = "id_tipopago";
                    break;
                case "tb_velocidad":
                    datos[0] = "velocidad";
                    datos[1] = "id_velocidad";
                    break;
                case "tb_cliente":
                    datos[0] = "nombre";
                    datos[1] = "id";
                    break;
                case "tb_router":
                    datos[0] = "router";
                    datos[1] = "id_router";
                    break;
                case "tb_router_new":
                    datos[0] = "router";
                    datos[1] = "id_router";
                    break;
                case "tb_red":
                    datos[0] = "CONCAT(redC,'.',redD) AS RED";
                    datos[1] = "id_red";
                    break;
                case "tb_subred":
                    datos[0] = "subred";
                    datos[1] = "id_subred";
                    break;
                case "tb_segmentacion":
                    datos[0] = "segmentacion";
                    datos[1] = "id_segmentacion";
                    break;
                case "tb_ip":
                    datos[0] = "ip";
                    datos[1] = "id_ip";
                    break;
                case "tb_maquina":
                    datos[0] = "maquina";
                    datos[1] = "id_maquina";
                    break;

                case "tb_meses":
                    datos[0] = "nombre_mes";
                    datos[1] = "id_mes";
                    break;

                case "tb_perfil":
                    datos[0] = "nombre";
                    datos[1] = "id_perfil";
                    break;

                case "tb_empleados":
                    datos[0] = "nombre";
                    datos[1] = "id_empleado";
                    break;

                /*CASE DE PRUEBA 2*/
                case "tb_ip_new":
                    datos[0] = "id_ip_new";
                    datos[1] = "id_ip_new";
                    break;

                case "tb_years":
                    datos[0] = "year";
                    datos[1] = "id_year";
                    break;


                case "tb_banco":
                    datos[0] = "banco";
                    datos[1] = "id_banco";
                    break;


                case "tb_estatus":
                    datos[0] = "estatus";
                    datos[1] = "id_estatus";
                    break;

                case "tb_antena":
                    datos[0] = "mac";
                    datos[1] = "id_antena";
                    break;

                case "tb_concepto":
                    datos[0] = "concepto";
                    datos[1] = "id_concepto";
                    break;

                case "tb_proveedor":
                    datos[0] = "proveedor";
                    datos[1] = "id_proveedor";
                    break;

                case "tb_status_factura":
                    datos[0] = "status_factura";
                    datos[1] = "id_status_factura";
                    break;

                case "tb_tipo_gasto":
                    datos[0] = "tipo_gasto";
                    datos[1] = "id_tipo_gasto";
                    break;

                case "tb_tipo_equipo":
                    datos[0] = "tipo_equipo";
                    datos[1] = "id_tipo_equipo";
                    break;

                case "tb_detalle_equipo":
                    datos[0] = "nombre";
                    datos[1] = "id_detalle_equipo";
                    break;

                case "tb_equipo":
                    datos[0] = "identificador";
                    datos[1] = "id_equipo";
                    break;

                case "tb_cuentas_c":
                    datos[0] = "nombre";
                    datos[1] = "id_cuenta_c";
                    break;
            }
            return datos;
        }
        public void _get_select_cbx(ComboBox cbx, string table)
        {
            string[] datos = set_select(table);
            get_cbx(table, datos[0], datos[1], cbx);
        }

        private string hash_pass(string pass)
        {
            byte[] varhashedBytes;
            var hash = "";
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                varhashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass));
                // Get the hashed string.  
                hash = BitConverter.ToString(varhashedBytes).Replace("-", "").ToLower();
            }
            return hash;
        }
        public void generate_pass()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 6;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }
            MessageBox.Show(contraseniaAleatoria);
            MessageBox.Show(hash_pass(contraseniaAleatoria));
        }
        public int load(string table, DataGridView dgv, string query)
        {
            return load_table(query, dgv, table);
        }
        public void pagination(string table, int indice, DataGridView dgv)
        {
            pagination_table(dgv, table, indice);
        }
    }
}
