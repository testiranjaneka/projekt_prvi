using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novi_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Mario je glavni, najglavnesi na svetu!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Hide();
        }
        Random ajmo = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(ajmo.Next(1, 255), ajmo.Next(1, 255), ajmo.Next(1, 255));
        }

    }
}
