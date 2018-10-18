using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int.TryParse(CmbTotal.Text, out int total);

            for(int i = 0; i < total; i++)
            {
                richTextBox1.AppendText(Guid.NewGuid().ToString() + "\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbTotal.Text = "10";
        }
    }
}
