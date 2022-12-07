using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Desafio2_02_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            link1.Visible= false;   
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            link1.Visible= true;
            
        }

        private void link(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.malvile.com");
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
