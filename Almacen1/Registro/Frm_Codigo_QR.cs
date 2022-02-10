using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace Almacen1.Registro
{
    public partial class Frm_Codigo_QR : Form
    {
        string Codigo;
        public Frm_Codigo_QR(string Codigo)
        {
            InitializeComponent();
            this.Codigo = Codigo;
        }

        private void Frm_Codigo_QR_Load(object sender, EventArgs e)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(Codigo,out qrCode);
            GraphicsRenderer Renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            Renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var ImagenTemporal = new Bitmap(ms);
            var Imagen = new Bitmap(ImagenTemporal, new Size(new Point(200,200)));
            PanelQR.BackgroundImage = Imagen;
        }

        void Guardar()
        {
            Image imgFinal = (Image)PanelQR.BackgroundImage.Clone();
            SaveFileDialog Guardado = new SaveFileDialog();
            Guardado.AddExtension = true;
            Guardado.Filter = "image PNG (*.png)|*.png";
            Guardado.ShowDialog();
            if (!string.IsNullOrEmpty(Guardado.FileName))
            {
                imgFinal.Save(Guardado.FileName, ImageFormat.Png);
            }
            Guardado.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            pdImprimir = new System.Drawing.Printing.PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = "POS58 Printer";
            pdImprimir.PrinterSettings = ps;
            pdImprimir.PrintPage += Imprimir;
            pdImprimir.Print();
        }
        void Imprimir (object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(PanelQR.BackgroundImage, new Point(0,0));
        }
    }
}
