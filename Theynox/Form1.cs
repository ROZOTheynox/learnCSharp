using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Premier_test_de_Csharp
{
    public partial class Form1 : Form
    {
        string maVarialGlobal = "test";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            maVarialGlobal = "1";
            bool estVrai = false;
            if (maVarialGlobal == "test");
            {
                estVrai = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maVarialGlobal = "2";
        }

        public void function()
        {
            string varFonction;
        }
    }
}
