using MySqlConnector;

namespace Almacen1.Class
{
    class ClsGlobales
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=127.0.0.1;PORT=3306;database=tb_almacen;Uid=root;pwd=;");
        }
    }
}
