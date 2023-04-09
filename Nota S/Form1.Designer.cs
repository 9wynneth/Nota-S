
namespace Nota_S
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NomorNota = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.checkBox_tomat = new System.Windows.Forms.CheckBox();
            this.checkBox_sambal = new System.Windows.Forms.CheckBox();
            this.labelTomatAtas = new System.Windows.Forms.Label();
            this.checkBox_dosTomat = new System.Windows.Forms.CheckBox();
            this.checkBox_dosSambal = new System.Windows.Forms.CheckBox();
            this.labelSambalAtas = new System.Windows.Forms.Label();
            this.numUpDown_jmlhTomat = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_jmlhSambal = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_dosSambal = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_dosTomat = new System.Windows.Forms.NumericUpDown();
            this.labelDosSambal = new System.Windows.Forms.Label();
            this.labelDosTomat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Note = new System.Windows.Forms.TextBox();
            this.errorProviderNoNota = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_jmlhTomat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_jmlhSambal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_dosSambal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_dosTomat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNoNota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal:";
            // 
            // textBox_NomorNota
            // 
            this.textBox_NomorNota.Location = new System.Drawing.Point(107, 21);
            this.textBox_NomorNota.Name = "textBox_NomorNota";
            this.textBox_NomorNota.Size = new System.Drawing.Size(207, 26);
            this.textBox_NomorNota.TabIndex = 4;
            this.textBox_NomorNota.TextChanged += new System.EventHandler(this.textBox_NomorNota_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Merk:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AMZ",
            "PG",
            "WSB",
            "BW"});
            this.comboBox1.Location = new System.Drawing.Point(108, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(404, 60);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(129, 76);
            this.btn_print.TabIndex = 9;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // checkBox_tomat
            // 
            this.checkBox_tomat.AutoSize = true;
            this.checkBox_tomat.Location = new System.Drawing.Point(108, 175);
            this.checkBox_tomat.Name = "checkBox_tomat";
            this.checkBox_tomat.Size = new System.Drawing.Size(80, 24);
            this.checkBox_tomat.TabIndex = 10;
            this.checkBox_tomat.Text = "Tomat";
            this.checkBox_tomat.UseVisualStyleBackColor = true;
            this.checkBox_tomat.CheckedChanged += new System.EventHandler(this.checkBox_tomat_CheckedChanged);
            // 
            // checkBox_sambal
            // 
            this.checkBox_sambal.AutoSize = true;
            this.checkBox_sambal.Location = new System.Drawing.Point(225, 175);
            this.checkBox_sambal.Name = "checkBox_sambal";
            this.checkBox_sambal.Size = new System.Drawing.Size(89, 24);
            this.checkBox_sambal.TabIndex = 11;
            this.checkBox_sambal.Text = "Sambal";
            this.checkBox_sambal.UseVisualStyleBackColor = true;
            this.checkBox_sambal.CheckedChanged += new System.EventHandler(this.checkBox_sambal_CheckedChanged);
            // 
            // labelTomatAtas
            // 
            this.labelTomatAtas.AutoSize = true;
            this.labelTomatAtas.Location = new System.Drawing.Point(104, 218);
            this.labelTomatAtas.Name = "labelTomatAtas";
            this.labelTomatAtas.Size = new System.Drawing.Size(59, 20);
            this.labelTomatAtas.TabIndex = 12;
            this.labelTomatAtas.Text = "jumlah:";
            this.labelTomatAtas.Visible = false;
            // 
            // checkBox_dosTomat
            // 
            this.checkBox_dosTomat.AutoSize = true;
            this.checkBox_dosTomat.Location = new System.Drawing.Point(107, 286);
            this.checkBox_dosTomat.Name = "checkBox_dosTomat";
            this.checkBox_dosTomat.Size = new System.Drawing.Size(109, 24);
            this.checkBox_dosTomat.TabIndex = 13;
            this.checkBox_dosTomat.Text = "Dos tomat";
            this.checkBox_dosTomat.UseVisualStyleBackColor = true;
            this.checkBox_dosTomat.Visible = false;
            this.checkBox_dosTomat.CheckedChanged += new System.EventHandler(this.checkBox_dosTomat_CheckedChanged);
            // 
            // checkBox_dosSambal
            // 
            this.checkBox_dosSambal.AutoSize = true;
            this.checkBox_dosSambal.Location = new System.Drawing.Point(225, 286);
            this.checkBox_dosSambal.Name = "checkBox_dosSambal";
            this.checkBox_dosSambal.Size = new System.Drawing.Size(122, 24);
            this.checkBox_dosSambal.TabIndex = 14;
            this.checkBox_dosSambal.Text = "Dos Sambal";
            this.checkBox_dosSambal.UseVisualStyleBackColor = true;
            this.checkBox_dosSambal.Visible = false;
            this.checkBox_dosSambal.CheckedChanged += new System.EventHandler(this.checkBox_dosSambal_CheckedChanged);
            // 
            // labelSambalAtas
            // 
            this.labelSambalAtas.AutoSize = true;
            this.labelSambalAtas.Location = new System.Drawing.Point(221, 218);
            this.labelSambalAtas.Name = "labelSambalAtas";
            this.labelSambalAtas.Size = new System.Drawing.Size(59, 20);
            this.labelSambalAtas.TabIndex = 15;
            this.labelSambalAtas.Text = "jumlah:";
            this.labelSambalAtas.Visible = false;
            // 
            // numUpDown_jmlhTomat
            // 
            this.numUpDown_jmlhTomat.Location = new System.Drawing.Point(107, 245);
            this.numUpDown_jmlhTomat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDown_jmlhTomat.Name = "numUpDown_jmlhTomat";
            this.numUpDown_jmlhTomat.Size = new System.Drawing.Size(53, 26);
            this.numUpDown_jmlhTomat.TabIndex = 16;
            this.numUpDown_jmlhTomat.Visible = false;
            this.numUpDown_jmlhTomat.ValueChanged += new System.EventHandler(this.numUpDown_jmlhTomat_ValueChanged);
            // 
            // numUpDown_jmlhSambal
            // 
            this.numUpDown_jmlhSambal.Location = new System.Drawing.Point(227, 245);
            this.numUpDown_jmlhSambal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDown_jmlhSambal.Name = "numUpDown_jmlhSambal";
            this.numUpDown_jmlhSambal.Size = new System.Drawing.Size(53, 26);
            this.numUpDown_jmlhSambal.TabIndex = 17;
            this.numUpDown_jmlhSambal.Visible = false;
            this.numUpDown_jmlhSambal.ValueChanged += new System.EventHandler(this.numUpDown_jmlhSambal_ValueChanged);
            // 
            // numUpDown_dosSambal
            // 
            this.numUpDown_dosSambal.Location = new System.Drawing.Point(227, 351);
            this.numUpDown_dosSambal.Name = "numUpDown_dosSambal";
            this.numUpDown_dosSambal.Size = new System.Drawing.Size(53, 26);
            this.numUpDown_dosSambal.TabIndex = 21;
            this.numUpDown_dosSambal.Visible = false;
            this.numUpDown_dosSambal.ValueChanged += new System.EventHandler(this.numUpDown_dosSambal_ValueChanged);
            // 
            // numUpDown_dosTomat
            // 
            this.numUpDown_dosTomat.Location = new System.Drawing.Point(107, 351);
            this.numUpDown_dosTomat.Name = "numUpDown_dosTomat";
            this.numUpDown_dosTomat.Size = new System.Drawing.Size(53, 26);
            this.numUpDown_dosTomat.TabIndex = 20;
            this.numUpDown_dosTomat.Visible = false;
            this.numUpDown_dosTomat.ValueChanged += new System.EventHandler(this.numUpDown_dosTomat_ValueChanged);
            // 
            // labelDosSambal
            // 
            this.labelDosSambal.AutoSize = true;
            this.labelDosSambal.Location = new System.Drawing.Point(221, 324);
            this.labelDosSambal.Name = "labelDosSambal";
            this.labelDosSambal.Size = new System.Drawing.Size(38, 20);
            this.labelDosSambal.TabIndex = 19;
            this.labelDosSambal.Text = "ikat:";
            this.labelDosSambal.Visible = false;
            // 
            // labelDosTomat
            // 
            this.labelDosTomat.AutoSize = true;
            this.labelDosTomat.Location = new System.Drawing.Point(104, 324);
            this.labelDosTomat.Name = "labelDosTomat";
            this.labelDosTomat.Size = new System.Drawing.Size(38, 20);
            this.labelDosTomat.TabIndex = 18;
            this.labelDosTomat.Text = "ikat:";
            this.labelDosTomat.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Note:";
            // 
            // textBox_Note
            // 
            this.textBox_Note.Location = new System.Drawing.Point(108, 413);
            this.textBox_Note.Name = "textBox_Note";
            this.textBox_Note.Size = new System.Drawing.Size(206, 26);
            this.textBox_Note.TabIndex = 23;
            this.textBox_Note.TextChanged += new System.EventHandler(this.textBox_Note_TextChanged);
            // 
            // errorProviderNoNota
            // 
            this.errorProviderNoNota.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.textBox_Note);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numUpDown_dosSambal);
            this.Controls.Add(this.numUpDown_dosTomat);
            this.Controls.Add(this.labelDosSambal);
            this.Controls.Add(this.labelDosTomat);
            this.Controls.Add(this.numUpDown_jmlhSambal);
            this.Controls.Add(this.numUpDown_jmlhTomat);
            this.Controls.Add(this.labelSambalAtas);
            this.Controls.Add(this.checkBox_dosSambal);
            this.Controls.Add(this.checkBox_dosTomat);
            this.Controls.Add(this.labelTomatAtas);
            this.Controls.Add(this.checkBox_sambal);
            this.Controls.Add(this.checkBox_tomat);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_NomorNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_jmlhTomat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_jmlhSambal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_dosSambal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_dosTomat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNoNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NomorNota;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.CheckBox checkBox_tomat;
        private System.Windows.Forms.CheckBox checkBox_sambal;
        private System.Windows.Forms.Label labelTomatAtas;
        private System.Windows.Forms.CheckBox checkBox_dosTomat;
        private System.Windows.Forms.CheckBox checkBox_dosSambal;
        private System.Windows.Forms.Label labelSambalAtas;
        private System.Windows.Forms.NumericUpDown numUpDown_jmlhTomat;
        private System.Windows.Forms.NumericUpDown numUpDown_jmlhSambal;
        private System.Windows.Forms.NumericUpDown numUpDown_dosSambal;
        private System.Windows.Forms.NumericUpDown numUpDown_dosTomat;
        private System.Windows.Forms.Label labelDosSambal;
        private System.Windows.Forms.Label labelDosTomat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Note;
        private System.Windows.Forms.ErrorProvider errorProviderNoNota;
    }
}

