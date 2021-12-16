using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Class
{
    class ClsConnectionServer
    {
        private MySqlDataAdapter adap = new MySqlDataAdapter();

        protected static MySqlConnection GetConnection()
        {
            return Class.ClsGlobales.GetConnection();
        }

        public bool ExecuteNonQuery(string query)
        {
            bool status = false;
            try
            {
                MySqlConnection con = GetConnection();
                MySqlCommand Command = new MySqlCommand(query, con);
                MySqlDataReader Reader;
                Command.Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    status = true;
                }
                else
                {
                    status = true;
                }
                con.Close();
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        public void ExecuteQuery(string query, DataGridView dgv)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection con = GetConnection();
                MySqlCommand Command = new MySqlCommand(query, con);

                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Command.Connection.Open();
                Adapter.SelectCommand = Command;
                Adapter.Fill(dt);
                dgv.DataSource = dt;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("algo anda mal por aqui:" + e, "error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void pagination_table(DataGridView dgv, string table, int indice)
        {
            try
            {
                DataSet dt = new DataSet();
                adap.Fill(dt, indice, 50, table);
                dgv.DataSource = dt.Tables[0];

            }
            catch (Exception)
            {

            }

        }
        public int load_table(string query, DataGridView dgv, string table)
        {
            int total = 0;
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            try
            {
                DataSet dt = new DataSet();
                MySqlConnection con = GetConnection();
                MySqlCommand Command = new MySqlCommand(query, con);
                Command.Connection.Open();
                Adapter.SelectCommand = Command;
                Adapter.Fill(dt);
                total = dt.Tables[0].Rows.Count;
                con.Close();
            }
            catch (Exception)
            {

            }
            adap = Adapter;
            return total;
        }
        public void Consultar(string query, DataTable dt)
        {
            try
            {
                MySqlConnection con = GetConnection();
                MySqlCommand Command = new MySqlCommand(query, con);
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Command.Connection.Open();
                Adapter.SelectCommand = Command;
                Adapter.Fill(dt);
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void ExecuteQueryCbx(string query, string name, string id, ComboBox cbx)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection con = GetConnection();
                MySqlCommand Command = new MySqlCommand(query, con);
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Command.Connection.Open();
                Adapter.SelectCommand = Command;
                Adapter.Fill(dt);
                cbx.DisplayMember = name;
                cbx.ValueMember = id;
                cbx.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
