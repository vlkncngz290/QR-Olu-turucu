using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bitekser_QR_Oluşturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQROlustur_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrCode1 = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            Zen.Barcode.CodeQrBarcodeDraw qrCode2 = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            Zen.Barcode.CodeQrBarcodeDraw qrCode3 = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrCode1.Draw("isim:"+txt1.Text+"soyisim"+txt2.Text+"firma:"+txt3.Text,1000);
            pictureBox2.Image = qrCode2.Draw(txt2.Text, 100);
            pictureBox3.Image = qrCode3.Draw(txt3.Text, 100);
        }

        private void exlAktar_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            //sheet1.Cells[1, 3] = pictureBox1.Image;
        }

        

    }
}
