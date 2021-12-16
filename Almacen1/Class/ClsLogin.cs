using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace Almacen1.Class
{
    class ClsLogin
    {
        ClsConnectionServer consult = new ClsConnectionServer();
        string query = "";
        public void login(string user, string passw, DataTable dt)
        {
            query = "SELECT * FROM tb_usuarios where user = '" + user + "' AND password = '" + passw + "'";
            consult.Consultar(query, dt);
        }

        public void obtener_nombre_empleaod_login(ref DataTable dt, string id_empleado)
        {
            query = "SELECT nombre FROM `tb_empleados` WHERE id_empleado=" + id_empleado;
            consult.Consultar(query, dt);
        }

        public void obtener_id_privilegio(ref DataTable dt, string id_empleado)
        {
            query = "SELECT id_privilegio FROM `tb_empleados` WHERE id_empleado=" + id_empleado;
            consult.Consultar(query, dt);
        }

        public void save_location(string usuario, string pass, string acceso)
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }

            NetworkInterface[] nif = NetworkInterface.GetAllNetworkInterfaces();
            String MACAddress = string.Empty;
            foreach (NetworkInterface adapter in nif)
            {
                if (MACAddress == String.Empty)
                {
                    IPInterfaceProperties ipproperties = adapter.GetIPProperties();
                    MACAddress = adapter.GetPhysicalAddress().ToString();
                }
            }

            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            //string externalip = "N/A";
            query = "INSERT INTO tb_inicio_sesion(ip, ip_publica, usuario, pass, nombre_pc, mac_address, acceso) VALUES ('" + localIP + "','" + externalip + "','" + usuario + "','" + pass + "','" + Environment.MachineName + "','" + MACAddress + "','" + acceso + "')";
            consult.ExecuteNonQuery(query);
        }


        private string GetMacAddress()
        {
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }

            return macAddresses;
        }
    }
}
