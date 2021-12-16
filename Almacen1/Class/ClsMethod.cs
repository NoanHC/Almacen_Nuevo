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
                case "tb_empleados":
                    datos[0] = "nombre";
                    datos[1] = "id_empleado";
                    break;

                case "tb_privilegios":
                    datos[0] = "privilegio";
                    datos[1] = "id_privilegio";
                    break;
                case "tb_status_usuario":
                    datos[0] = "status";
                    datos[1] = "id_status_usuario";
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
