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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        public static string LogInName;
        public static int LogInID;
        public static int UserID;
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp f2 = new SignUp();
            f2.Show();
        }

        private void LogIn_Load(object sender, EventArgs e)
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

        private void Conectare_Click(object sender, EventArgs e)
        {
            string nume = textBoxNume.Text;
            string parola = textBoxParola.Text;

            if(textBoxNume.Text!="" && textBoxParola.Text!="")
            {
                int gasit = 0;
                for(int i = 0; i < utilizatoriDataSet.Utilizatori.Count && gasit ==0 ; i++)
                {
                    if (utilizatoriDataSet.Utilizatori[i].Nume_utilizator==nume && utilizatoriDataSet.Utilizatori[i].Parola==parola)
                    {
                        LogInID = i;
                        UserID = utilizatoriDataSet.Utilizatori[LogInID].Id;
                        LogInName = nume;
                        gasit = 1;
                        this.Hide();
                        Home f3 = new Home();
                        f3.Show();
                    }
                    
                }
                if(gasit == 0)
                {
                    MessageBox.Show("Nu aveti cont", "Conectare esuata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                
                MessageBox.Show("Introduceti datele", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBxArataparola.Checked)
            {
                textBoxParola.PasswordChar = '\0';
            }
            else
            {
                textBoxParola.PasswordChar = '*';
            }
        }
    }
}
