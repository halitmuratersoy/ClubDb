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
    public partial class Enroll : Form
    {
        public Enroll()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Enroll' table. You can move, or remove it, as needed.
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vp, vp2, vp3;
            int.TryParse(textBox1.Text, out vp);
            int.TryParse(comboBox1.Text, out vp2);
            int.TryParse(comboBox2.Text, out vp3);
            this.enrollTableAdapter.Insert(vp, vp2, vp3);
            this.enrollTableAdapter.Fill(dataSet1.Enroll);
        }
    }
}
