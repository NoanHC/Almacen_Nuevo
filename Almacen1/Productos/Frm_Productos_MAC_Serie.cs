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
        // Variables
        int Id;
        int FilaS = 0;
        int FilaM = 0;

        public Frm_Productos_MAC_Serie(int AuxPrimera, DataTable dtN)
        {
            InitializeComponent();
            Id = Convert.ToInt32(dtN.Rows[0][0].ToString());
            dtN.Columns.Remove("id");
            dtN.Columns.Remove("Cantidad");
            DGV1.DataSource = dtN;
            switch (AuxPrimera)
            {
                case 1:
                    PanelSerie.Visible = false;
                    PanelMAC.Top = 0;
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
        void AgregarSerie ()
        {
            for (int i = 0; i < DGV1.Rows.Count; i++)
            {
                if (DGV1[4, i].Value.ToString() == "")
                {
                    FilaS = i;
                    break;
                }
            }
            DGV1[4, FilaS].Value = txtSerie.Text;
            FilaS++;
        }
        void Final ()
        {
            bool Checador = true;
            for (int i = 0; i < DGV1.Rows.Count; i++)
            {
                if (DGV1[4, i].Value.ToString() == "")
                {
                    Checador = false;
                }
            }
            if (Checador)
            {
                if (MessageBox.Show("¿Desea teminar?", "Terminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < DGV1.Rows.Count; i++)
                    {
                        for (int j = 4; j < 6; j++)
                        {
                            if (DGV1[j,i].Value.ToString() != "")
                            {
                                
                            }
                        }
                    }
                }
            }
        }
        private void btnAgregarSerie_Click(object sender, EventArgs e)
        {
            AgregarSerie();
            Final();
        }
        void BorrarSerie(int FilaDGV)
        {
            if (MessageBox.Show("¿Desea borrar la serie " + DGV1[4, FilaDGV].Value.ToString() + "?", "Borrar serie", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DGV1[4, FilaDGV].Value = "";
            }
        }
        void BorrarMAC(int FilaDGV)
        {
            if (MessageBox.Show("¿Desea borrar la MAC " + DGV1[5, FilaDGV].Value.ToString() + "?", "Borrar serie", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DGV1[5, FilaDGV].Value = "";
            }
        }
        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 4)
                {
                    if (DGV1[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                    {
                        BorrarSerie(e.RowIndex);
                    }
                }
                if (e.ColumnIndex == 5)
                {
                    if (DGV1[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                    {
                        BorrarMAC(e.RowIndex);
                    }
                }
            }
        }

        void AgregarMAC()
        {
            for (int i = 0; i < DGV1.Rows.Count; i++)
            {
                if (DGV1[5, i].Value.ToString() == "")
                {
                    FilaM = i;
                    break;
                }
            }
            DGV1[5, FilaM].Value = txtSerie.Text;
            FilaM++;
        }

        private void btnAgregarMAC_Click(object sender, EventArgs e)
        {
            AgregarMAC();
        }
    }
}
