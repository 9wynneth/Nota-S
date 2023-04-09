using System;
using System.Windows.Forms;

namespace Nota_S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string nomorNota;
        public static string tanggalNota;
        public static string merk;
        public static string note;
        public static bool cekTomat = false;
        public static decimal jumlahTomat;
        public static bool cekDosTomat = false;
        public static decimal jumlahDosTomat;
        public static bool cekSambal = false;
        public static decimal jumlahSambal;
        public static bool cekDosSambal = false;
        public static decimal jumlahDosSambal;
        public bool tanggalGanti = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_NomorNota_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox_tomat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tomat.Checked == true)
            {
                labelTomatAtas.Visible = true;
                numUpDown_jmlhTomat.Visible = true;
                checkBox_dosTomat.Visible = true;
                cekTomat = true;
            }
            else
            {
                cekTomat = false;
                hideTomatatas();
                hideDosTomat();
            }
        }

        public void hideTomatatas()
        {
            labelTomatAtas.Visible = false;
            numUpDown_jmlhTomat.Visible = false;
            checkBox_dosTomat.Visible = false;
        }

        public void hideSambalatas()
        {
            labelSambalAtas.Visible = false;
            numUpDown_jmlhSambal.Visible = false;
            checkBox_dosSambal.Visible = false;
        }

        public void hideDosSambal()
        {
            labelDosSambal.Visible = false;
            numUpDown_dosSambal.Visible = false;
        }

        public void hideDosTomat()
        {
            labelDosTomat.Visible = false;
            numUpDown_dosTomat.Visible = false;
        }

        private void checkBox_dosTomat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dosTomat.Checked == true && checkBox_tomat.Checked == true)
            {
                labelDosTomat.Visible = true;
                numUpDown_dosTomat.Visible = true;
                cekDosTomat = true;
            }
            else
            {
                hideDosTomat();
                cekDosTomat = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tanggalGanti = true;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            tanggalNota = dateTimePicker1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            merk = comboBox1.SelectedItem.ToString();
        }

        private void checkBox_sambal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sambal.Checked == true)
            {
                labelSambalAtas.Visible = true;
                numUpDown_jmlhSambal.Visible = true;
                checkBox_dosSambal.Visible = true;
                cekSambal = true;
            }
            else
            {
                cekSambal = false;
                hideSambalatas();
                hideDosSambal();
            }
        }

        private void checkBox_dosSambal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dosSambal.Checked == true && checkBox_sambal.Checked == true)
            {
                labelDosSambal.Visible = true;
                numUpDown_dosSambal.Visible = true;
                cekDosSambal = true;
            }
            else
            {
                cekDosSambal = false;
                hideDosSambal();
            }
        }

        private void textBox_Note_TextChanged(object sender, EventArgs e)
        {
            note = textBox_Note.Text;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (textBox_NomorNota.Text == "")
            {
                errorProviderNoNota.SetError(this.textBox_NomorNota, "No. Nota belum diisi!");
                return;
            }
            else
            {
                errorProviderNoNota.Clear();
                nomorNota = textBox_NomorNota.Text;
                if (tanggalGanti == false)
                {
                    string message = "Apakah anda yakin TANGGAL sudah sesuai?";
                    string title = "Peringatan";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes && textBox_NomorNota.Text != "")
                    {
                        
                        dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        tanggalNota = dateTimePicker1.Text;
                        if (jumlahTomat == 0 && checkBox_tomat.Checked == true)
                        {
                            MessageBox.Show("Jumlah tomat masih 0! Jika memang benar, mohon jangan mencentang pilihan tomat!");
                        }
                        else
                        {
                            Form_Output output2 = new Form_Output();
                            output2.Show();
                           
                        }

                    }
                }
                else if (jumlahTomat == 0 && checkBox_tomat.Checked == true)
                {
                    MessageBox.Show("Jumlah tomat masih 0! Jika memang benar, mohon jangan mencentang pilihan tomat!");
                }
                else
                {
                    Form_Output output2 = new Form_Output();
                    output2.Show();

                }

            }

        }

        private void numUpDown_jmlhTomat_ValueChanged(object sender, EventArgs e)
        {
            cekTomat = true;
            jumlahTomat = numUpDown_jmlhTomat.Value;
        }

        private void numUpDown_jmlhSambal_ValueChanged(object sender, EventArgs e)
        {
            cekSambal = true;
            jumlahSambal = numUpDown_jmlhSambal.Value;
        }

        private void numUpDown_dosTomat_ValueChanged(object sender, EventArgs e)
        {
            cekDosTomat = true;
            jumlahDosTomat = numUpDown_dosTomat.Value;
        }

        private void numUpDown_dosSambal_ValueChanged(object sender, EventArgs e)
        {
            cekDosSambal = true;
            jumlahDosSambal = numUpDown_dosSambal.Value;
        }
    }
}
