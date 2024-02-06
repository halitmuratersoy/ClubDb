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
    public partial class ClubDatabase : Form
    {
        public ClubDatabase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            team.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Coach coach = new Coach();
            coach.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Parent parent = new Parent();
            parent.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Enroll enroll = new Enroll();
            enroll.ShowDialog();
        }
    }
}
