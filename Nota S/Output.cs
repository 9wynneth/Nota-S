using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Drawing.Imaging;

namespace Nota_S
{
    public partial class Form_Output : Form
    {

       
        public Form_Output()
        {
            InitializeComponent();
        }

        public bool isRowEmpty(DataTable dt, int index)
        {
            DataRow row = dt.Rows[index];
            return dt.Columns.Cast<DataColumn>()
                .All(c => row.IsNull(c) || string.IsNullOrWhiteSpace(row[c].ToString()));
        }

        DataTable dtIsi = new DataTable();

        private void tomat()
        {

            DataRow rowTomat = dtIsi.NewRow();
            rowTomat["BANYAKNYA"] = $"{Form1.jumlahTomat} dos";
            rowTomat["NAMA BARANG"] = "Saos Siliwangi";
            rowTomat["HARGA"] = 42200;
            rowTomat["JUMLAH"] = Form1.jumlahTomat * 42200;

            dtIsi.Rows.Add(rowTomat);
        }

        private void sambal()
        {
            DataRow rowSambal = dtIsi.NewRow();
            rowSambal["BANYAKNYA"] = $"{Form1.jumlahSambal} dos";
            rowSambal["NAMA BARANG"] = "Sambal Siliwangi";
            rowSambal["HARGA"] = 50200;
            rowSambal["JUMLAH"] = Form1.jumlahSambal * 50200;
            dtIsi.Rows.Add(rowSambal);
        }

        private void merica()
        {
            DataRow rowMerica = dtIsi.NewRow();
            rowMerica["BANYAKNYA"] = $"{Form1.jumlahMerica} dos";
            rowMerica["NAMA BARANG"] = "Merica Siliwangi";
            rowMerica["HARGA"] = 235000;
            rowMerica["JUMLAH"] = Form1.jumlahMerica * 235000;
            dtIsi.Rows.Add(rowMerica);
        }
        private void noteData()
        {
            DataRow rowNoteData = dtIsi.NewRow();
            rowNoteData["NAMA BARANG"] = Form1.noteDataTable;
            dtIsi.Rows.Add(rowNoteData);
        }

        private void dosSambal()
        {
            DataRow rowDos = dtIsi.NewRow();
            rowDos["BANYAKNYA"] = $"{Form1.jumlahDosSambal} ikat";
            rowDos["NAMA BARANG"] = "Karton sambal";

            dtIsi.Rows.Add(rowDos);
        }

        private void dosTomat()
        {
            DataRow rowDos = dtIsi.NewRow();
            rowDos["BANYAKNYA"] = $"{Form1.jumlahDosTomat} ikat";
            rowDos["NAMA BARANG"] = "Karton tomat";

            dtIsi.Rows.Add(rowDos);
        }

        private void Output_Load(object sender, EventArgs e)
        {
            //button1.Visible = false;
            dtIsi.Columns.Add("BANYAKNYA", typeof(String));
            dtIsi.Columns.Add("NAMA BARANG", typeof(String));
            dtIsi.Columns.Add("HARGA", typeof(System.Int32));
            dtIsi.Columns.Add("JUMLAH", typeof(System.Int32));

            dGV_output.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //tBox_totalHarga.Enabled = false;

            lbl_hslNoNota.Text = Form1.nomorNota;
            lbl_hslTanggal.Text = Form1.tanggalNota;
            lbl_hslMerk.Text = Form1.merk;
            lbl_hslNotes.Text = Form1.note;
            if (Form1.merk == "AMZ" || Form1.merk =="BW")
            {
                lbl_hslTuan.Text = "Ko Ronald";
                lbl_hslTokoKota.Text = "Kalabahi";
            }
            else if (Form1.merk == "PG")
            {
                lbl_hslTuan.Text = "PG";
                lbl_hslTokoKota.Text = "Luwuk";
            }
            else if (Form1.merk == "WSB")
            {
                lbl_hslTuan.Text = "Ko Rudi";
                lbl_hslTokoKota.Text = "Atapupu";
            }

            if (Form1.cekTomat == true)
            {
                tomat();
                if (Form1.cekSambal == true)
                {
                    sambal();
                }
                if (Form1.cekMerica == true)
                {
                    merica();
                }
                if (Form1.cekDosTomat == true && Form1.cekTomat==true)
                {
                    dosTomat();
                }
                if (Form1.cekDosSambal == true && Form1.cekSambal==true)
                {
                    dosSambal();
                }

                for (int i = 0; i < dtIsi.Rows.Count; i++)
                {
                    if (isRowEmpty(dtIsi, i))
                        continue;
                }
            }

            else if (Form1.cekSambal == true)
            {
                sambal();
                if (Form1.cekTomat == true)
                {
                    tomat();
                }
                if (Form1.cekMerica == true)
                {
                    merica();
                }
                if (Form1.cekDosTomat == true && Form1.cekTomat==true)
                {
                    dosTomat();
                }
                if (Form1.cekDosSambal == true && Form1.cekSambal==true)
                {
                    dosSambal();
                }
            }
            else if (Form1.cekMerica == true)
            {
                merica();
                if (Form1.cekTomat == true)
                {
                    tomat();
                }
                if (Form1.cekSambal == true)
                {
                    sambal();
                }
                if (Form1.cekDosTomat == true && Form1.cekTomat == true)
                {
                    dosTomat();
                }
                if (Form1.cekDosSambal == true && Form1.cekSambal == true)
                {
                    dosSambal();
                }
            }
            noteData();

            dGV_output.EnableHeadersVisualStyles = false;
            dGV_output.DataSource = dtIsi;

            dGV_output.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dGV_output.RowsDefaultCellStyle.BackColor = Color.White;
            dGV_output.RowsDefaultCellStyle.ForeColor = Color.Black;
            dGV_output.DefaultCellStyle.SelectionBackColor = Color.White;
            dGV_output.DefaultCellStyle.SelectionForeColor = Color.Black;
            dGV_output.BackgroundColor = Color.White;

            foreach (DataGridViewColumn column in dGV_output.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            dGV_output.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            object sumObject;
            sumObject = dtIsi.Compute("Sum(JUMLAH)", string.Empty);

            string store = sumObject.ToString();
            int storeangka = Convert.ToInt32(store);
         
            label14.Text = storeangka.ToString("#,##0.00");

        }

        private bool isButtonVisible = true;
/*        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save Screenshot";
                saveFileDialog.FileName = "screenshot.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hide the button
                    isButtonVisible = button1.Visible;
                    button1.Visible = false;

                    // Create a bitmap with the form's size
                    Bitmap screenshot = new Bitmap(this.Width, this.Height);

                    // Draw the form and its controls onto the bitmap
                    this.DrawToBitmap(screenshot, new Rectangle(0, 0, screenshot.Width, screenshot.Height));

                    // Save the screenshot
                    screenshot.Save(saveFileDialog.FileName, ImageFormat.Png);

                    // Restore the button visibility
                    button1.Visible = isButtonVisible;
                }
            }
        }*/
    }
}
