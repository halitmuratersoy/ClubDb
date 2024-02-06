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
    public partial class Coach : Form
    {
        public Coach()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.dataSet1.Coach);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vp;
            int vp2;
            int.TryParse(textBox1.Text, out vp);
            int.TryParse(comboBox1.Text, out vp2);
            this.coachTableAdapter.Insert(vp, textBox2.Text, textBox3.Text, textBox4.Text, vp2);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }
    }
}
