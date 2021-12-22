using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Productos
{
    public partial class Frm_Productos_MAC_Serie : Form
    {
        public Frm_Productos_MAC_Serie(int AuxPrimera, DataTable dtN)
        {
            InitializeComponent();
            DGV1.DataSource = dtN;
            switch (AuxPrimera)
            {
                case 1:
                    PanelSerie.Visible = false;
                    break;
                case 2:
                    PanelMAC.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void Frm_Productos_MAC_Serie_Load(object sender, EventArgs e)
        {

        }
    }
}
