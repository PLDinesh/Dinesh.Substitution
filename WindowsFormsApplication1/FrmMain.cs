using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void SourceText_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encrypt Enc = new Encrypt();
            ChiperText.Text = Enc.GetTransformedString(SourceText.Text);


            //Decrypt Dec = new Decrypt();
            //ChiperText.Text = Dec.GetTransformedString(ChiperText.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decrypt Dec = new Decrypt();
            SourceText.Text = Dec.GetTransformedString(ChiperText.Text);
        }
    }
}
