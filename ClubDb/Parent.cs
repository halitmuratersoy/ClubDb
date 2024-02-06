using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDb
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Parent' table. You can move, or remove it, as needed.
            this.parentTableAdapter.Fill(this.dataSet1.Parent);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vp;
            int.TryParse(textBox1.Text, out vp);
            this.parentTableAdapter.Insert(vp, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            this.parentTableAdapter.Fill(this.dataSet1.Parent);
        }
    }
}
