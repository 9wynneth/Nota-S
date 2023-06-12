
namespace Nota_S
{
    partial class Intro
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
            this.btn_viewEditDataHIstory = new System.Windows.Forms.Button();
            this.btn_BuatNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_viewEditDataHIstory
            // 
            this.btn_viewEditDataHIstory.Location = new System.Drawing.Point(214, 157);
            this.btn_viewEditDataHIstory.Name = "btn_viewEditDataHIstory";
            this.btn_viewEditDataHIstory.Size = new System.Drawing.Size(124, 106);
            this.btn_viewEditDataHIstory.TabIndex = 0;
            this.btn_viewEditDataHIstory.Text = "EDIT";
            this.btn_viewEditDataHIstory.UseVisualStyleBackColor = true;
            // 
            // btn_BuatNota
            // 
            this.btn_BuatNota.Location = new System.Drawing.Point(436, 164);
            this.btn_BuatNota.Name = "btn_BuatNota";
            this.btn_BuatNota.Size = new System.Drawing.Size(124, 99);
            this.btn_BuatNota.TabIndex = 1;
            this.btn_BuatNota.Text = "BUAT NOTA";
            this.btn_BuatNota.UseVisualStyleBackColor = true;
            this.btn_BuatNota.Click += new System.EventHandler(this.btn_BuatNota_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_BuatNota);
            this.Controls.Add(this.btn_viewEditDataHIstory);
            this.Name = "Intro";
            this.Text = "Intro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewEditDataHIstory;
        private System.Windows.Forms.Button btn_BuatNota;
    }
}