using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName, lastName, group;

            firstName = Convert.ToString(textBox1.Text);

            lastName = Convert.ToString(textBox2.Text);

            group = Convert.ToString(textBox3.Text);

            string[] lines = { firstName, lastName, group };

            System.IO.File.WriteAllLines(@"WriteLines.txt", lines);

        }

        
    }
}
