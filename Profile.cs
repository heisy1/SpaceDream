using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceDream
{
    public partial class Profile : Form
    {
        public static int IdUser;
        public static Profile Instance = null;
        public Profile()
        {
            InitializeComponent();
            Profile.Instance = this;
        }
        string photopath;
        byte[] binaryphoto;
       
        private Form activeForm = null;
        private void openChildForm(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            paneleditprofile.Controls.Add(childform);
            paneleditprofile.Tag = childform;
            childform.BringToFront();
            childform.Show();
            paneleditprofile.Visible = true;
            paneleditprofile.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            openChildForm(new Editprofile());
        }
        
        private void paneleditprofile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilizatoriDataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.utilizatoriDataSet.Utilizatori);
            IdUser = LogIn.LogInID;
            labelUsername.Text = utilizatoriDataSet.Utilizatori[IdUser].Nume_utilizator;
            label1.Text = utilizatoriDataSet.Utilizatori[IdUser].Puncte.ToString();

                if (utilizatoriDataSet.Utilizatori[IdUser].Pozadeprofil != "")
                {
                    photopath = @utilizatoriDataSet.Utilizatori[IdUser].Pozadeprofil;
                    pictureBoxProfile.Image = Image.FromFile(photopath);
                    pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                    FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    binaryphoto = br.ReadBytes((int)fs.Length);
                    fs.Close();
                }

        }

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.utilizatoriDataSet);

        }
        
        private void labelHome_Click(object sender, EventArgs e)
        {
            //(this.Owner as Home).panelProfile.Visible = false;
            this.Close();
            Home.Instance.panelProfile.Visible = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
