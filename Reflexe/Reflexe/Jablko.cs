using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflexe
{
    public partial class Jablko : UserControl
    {
        public Jablko()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void GetSmashed()
        {
            if(progressBar1.Value >= 75)
            {
                progressBar1.Value = progressBar1.Maximum;
                pictureBox1.Image = Image.FromFile("stahování (2).jpg");
            }
            else
            {
                progressBar1.Value += 25;
            }
            
        }
    }
}
