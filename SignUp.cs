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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilizatoriDataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.utilizatoriDataSet.Utilizatori);

        }

        private void InapoiSu_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn f1 = new LogIn();
            f1.Show();
        }

        private void InscrieteSu_Click(object sender, EventArgs e)
        {
            string nume = textBoxNume.Text;
            string parola = txtBoxParola.Text;
            string email = textBoxEmail.Text;

            int cont = 0;
            if(nume=="" && parola=="" && email=="")
            {
                MessageBox.Show("Nu ati introdus Numele, parola si e-mailul", "Inscriere esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                for(int i=0;i<utilizatoriDataSet.Utilizatori.Count && cont ==0;i++)
                {
                    if (utilizatoriDataSet.Utilizatori[i].Nume_utilizator == nume)
                    {
                        cont = 1;
                        MessageBox.Show("Aveti deja cont", "Inscriere esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if(cont==0)
            {
                utilizatoriTableAdapter.InsertQueryUtilizator(nume, parola, email, @"E:\Atestat\SpaceDream\bin\Debug\blank-profile-picture.png", 0);
                        utilizatoriTableAdapter.Fill(utilizatoriDataSet.Utilizatori);
                        this.Close();
                        LogIn f1 = new LogIn();
                        f1.Show();
            }
        }

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.utilizatoriDataSet);

        }

        private void checkBxArataparola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxArataparola.Checked)
            {
                txtBoxParola.PasswordChar = '\0';
            }
            else
            {
                txtBoxParola.PasswordChar = '*';
            }
        }
    }
}
