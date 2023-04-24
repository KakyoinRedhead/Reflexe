using System.Reflection;

namespace Reflexe
{
    public partial class Form1 : Form
    {
        //kod pro plaginy a zobrazení
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.GetType().Name);
                if (control is Bryle)
                {
                    Bryle bryle = (Bryle)control;
                    bryle.Vysmejse();
                }
                else if (control is Jablko)
                {
                    Jablko jablko = (Jablko)control;
                    jablko.GetSmashed();
                }
            }
        }
    }
}