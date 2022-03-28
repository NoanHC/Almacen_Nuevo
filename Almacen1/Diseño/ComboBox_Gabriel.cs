using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Librerias extras
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Almacen1.Diseño
{
    [DefaultEvent("Seleccion")]
    class ComboBox_Gabriel: UserControl
    {
        // Apariencia
        private Color Fondo = Color.WhiteSmoke;
        private Color Icono = Color.MediumSlateBlue;
        private Color FondoLista = Color.FromArgb(230, 228, 245);
        private Color TextoLista = Color.DimGray;
        private Color Borde = Color.MediumSlateBlue;
        private int TamañoBorde = 1;

        // Elementos
        private ComboBox CBLista;
        private Label lblTexto;
        private Button btnIcono;

        // Eventos
        public event EventHandler Seleccion;

        // Constructor
        public ComboBox_Gabriel()
        {
            CBLista = new ComboBox();
            lblTexto = new Label();
            btnIcono = new Button();

            // Lista
            CBLista.BackColor = Fondo;
            CBLista.Font = new Font(this.Font.Name, 10F);
            CBLista.ForeColor = TextoLista;
            CBLista.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            CBLista.TextChanged += new EventHandler(ComboBox_TextChanged);

            // Boton : Icono
            btnIcono.Dock = DockStyle.Right;
            btnIcono.FlatStyle = FlatStyle.Flat;
            btnIcono.FlatAppearance.BorderSize = 0;
            btnIcono.BackColor = Fondo;
            btnIcono.Size = new Size(30, 30);
            btnIcono.Cursor = Cursors.Hand;
            btnIcono.Click += new EventHandler(Icon_Click);
            btnIcono.Paint += new PaintEventHandler(Icon_Paint);

            // Label : Texto
            lblTexto.Dock = DockStyle.Fill;
            lblTexto.AutoSize = false;
            lblTexto.BackColor = Fondo;
            lblTexto.TextAlign = ContentAlignment.MiddleLeft;
            lblTexto.Padding = new Padding(8,0,0,0);
            lblTexto.Font = new Font(this.Font.Name, 10F);
            lblTexto.Click += new EventHandler(Surface_Click);

            //Use Control
            this.Controls.Add(lblTexto);
            this.Controls.Add(btnIcono);
            this.Controls.Add(CBLista);
            this.MinimumSize = new Size(200,30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(TamañoBorde);
            base.BackColor = Borde;
            this.ResumeLayout();
            AdjustComboBoxDimension();

        }
        // Metodos Privados
        
        private void AdjustComboBoxDimension()
        {
            CBLista.Width = lblTexto.Width;
            CBLista.Location = new Point()
            {
                X = this.Width - this.Padding.Right - CBLista.Width,
                Y = lblTexto.Bottom - CBLista.Height
            };
        }
        // Metodos de eventos

        // Evento por defecto
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Seleccion != null)
                Seleccion.Invoke(sender, e);
            // Refresh texto
            lblTexto.Text = CBLista.Text;
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            // Select ComboBox
            CBLista.Select();
            if (CBLista.DropDownStyle == ComboBoxStyle.DropDownList)
                CBLista.DroppedDown = true;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            // Apariencia
            int IconWidht = 14;
            int IconHeight = 6;
            var RectIcon = new Rectangle((btnIcono.Width - IconWidht) / 2, (btnIcono.Height - IconHeight) / 2, IconWidht, IconHeight);
            Graphics Grafo = e.Graphics;

            // Dibujar flecha mirando para abajo.
            using (GraphicsPath Path = new GraphicsPath())
            using (Pen pen = new Pen(Icono, 2))
            {
                Grafo.SmoothingMode = SmoothingMode.AntiAlias;
                Path.AddLine(RectIcon.X, RectIcon.Y, RectIcon.X + (IconWidht / 2), RectIcon.Bottom);
                Path.AddLine(RectIcon.X + (IconWidht / 2), RectIcon.Bottom, RectIcon.Right, RectIcon.Y);
                Grafo.DrawPath(pen, Path);
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            // Open DropDown List
            CBLista.Select();
            CBLista.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            // Refresh texto
            lblTexto.Text = CBLista.Text;
        }

        
    }
}
