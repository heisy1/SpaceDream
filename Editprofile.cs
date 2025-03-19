using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceDream
{
    public partial class Editprofile : Form
    {
        public int IdUser = LogIn.UserID;
        public event Action ReloadForm1;
        public Editprofile()
        {
            InitializeComponent();
        }
        private void Editprofile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilizatoriDataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.utilizatoriDataSet.Utilizatori);
        }

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.utilizatoriDataSet);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string numeNou= textBoxNume.Text;
            if (numeNou != "")
            {
                utilizatoriTableAdapter.UpdateQueryNume(numeNou,IdUser);
                utilizatoriTableAdapter.Fill(utilizatoriDataSet.Utilizatori);
            }
            Profile.Instance.paneleditprofile.Visible = false;
            
            this.Close();
            Profile.Instance.Close();
            //Home.Instance.panelProfile.Visible = true;
            Home.Instance.openChildForm(new Profile());

        }
        string photopath;
        byte[] binaryphoto;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg|Jpegs|*.Jpegs|png|*.png|Gif|*.Gif|Bitmaps|*.Bitmaps";
            file.Title = "Selecteaza o imagine";
            if (file.ShowDialog() == DialogResult.OK)
            {
                photopath = file.FileName;
                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();
                utilizatoriTableAdapter.UpdateQueryPozadeProfil(photopath,IdUser);
                utilizatoriTableAdapter.Fill(utilizatoriDataSet.Utilizatori);
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esti sigur ca vrei sa stergi contul?","Informare",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                utilizatoriTableAdapter.DeleteQueryUtilizator(IdUser);
                this.Close();
                Home.Instance.Close();
                Application.Restart();
            }
        }
    }
}
