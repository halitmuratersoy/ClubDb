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
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.dataSet1.Team);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            int.TryParse(textBox1.Text, out value);
            this.teamTableAdapter.Insert(value, textBox2.Text, textBox3.Text);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }
    }
}
