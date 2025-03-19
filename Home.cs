using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceDream
{
    public partial class Home : Form
    {
        public static Home Instance = null;
        public Home()
        {
            InitializeComponent();
            Home.Instance = this;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        public Form activeForm = null;
        public void openChildForm(Form childform)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            //childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelProfile.Controls.Add(childform);
            panelProfile.Tag = childform;
            childform.BringToFront();
            childform.Show();
            panelProfile.Visible = true;
            panelProfile.BringToFront();
        }

        private void profilulMeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Profile());
           
        }

        public void panelProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void invataDespreSpatiuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Learn());
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openChildForm(new Quiz1());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            openChildForm(new Quiz2());
        }

        private void fdsafdsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Leaderboard());
        }
    }
}
