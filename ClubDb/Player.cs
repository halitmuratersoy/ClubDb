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
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.dataSet1.Team);
            // TODO: This line of code loads data into the 'dataSet1.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.dataSet1.Player);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vp;
            int vp2;
            int.TryParse(textBox1.Text, out vp);
            int.TryParse(comboBox1.Text, out vp2);
            this.playerTableAdapter.Insert(vp, textBox2.Text, textBox3.Text, textBox4.Text, vp2);
            this.playerTableAdapter.Fill(this.dataSet1.Player);
        }
    }
}
