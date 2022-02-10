using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1
{
    public partial class Frm_Notas : Form
    {
        public string Notas = "";
        public Frm_Notas()
        {
            InitializeComponent();
        }

        private void llblGuardar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Notas = rtbNotas.Text;
            this.Close();
        }

        private void llblNoInformar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
