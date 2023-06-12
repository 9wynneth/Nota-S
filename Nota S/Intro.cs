using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nota_S
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void btn_BuatNota_Click(object sender, EventArgs e)
        {
            
            Form1 entering = new Form1();
            entering.Show();
            this.Hide();

            
        }
    }
}
