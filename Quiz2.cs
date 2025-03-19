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
    public partial class Quiz2 : Form
    {
        public int Iduser = LogIn.UserID;
        public Quiz2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home.Instance.panelProfile.Visible = false;
        }

        int corectanswear = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="8")
            {
                corectanswear++;
            }
            else
            {
                pictureBox1.Visible = true;
                label1.Visible = true;
            }

            if(checkBox3.Checked==true)
            {
                corectanswear++;
                panel10.BackColor = Color.Green;
            }
            else if (checkBox1.Checked == true)
            {
                panel8.BackColor = Color.Red;
            }
            else if (checkBox2.Checked == true)
            {
                panel9.BackColor = Color.Red;
            }
            else if (checkBox4.Checked == true)
            {
                panel11.BackColor = Color.Red;
            }

            if (checkBox5.Checked == true)
            {
                corectanswear++;
                panel12.BackColor = Color.Green;
            }
            else if (checkBox7.Checked == true)
            {
                panel14.BackColor = Color.Red;
            }
            else if (checkBox6.Checked == true)
            {
                panel13.BackColor = Color.Red;
            }
            else if (checkBox8.Checked == true)
            {
                panel15.BackColor = Color.Red;
            }

            if (checkBox12.Checked == true)
            {
                corectanswear++;
                panel19.BackColor = Color.Green;
            }
            else if (checkBox9.Checked == true)
            {
                panel16.BackColor = Color.Red;
            }
            else if (checkBox11.Checked == true)
            {
                panel18.BackColor = Color.Red;
            }
            else if (checkBox10.Checked == true)
            {
                panel17.BackColor = Color.Red;
            }

            if (checkBox14.Checked == true)
            {
                corectanswear++;
                panel20.BackColor = Color.Green;
            }
            else if (checkBox13.Checked == true)
            {
                panel3.BackColor = Color.Red;
            }
            else if (checkBox15.Checked == true)
            {
                panel21.BackColor = Color.Red;
            }
            else if (checkBox16.Checked == true)
            {
                panel22.BackColor = Color.Red;
            }

            panel4.Visible = true;
            label7.Text = corectanswear.ToString();
            int points = utilizatoriDataSet.Utilizatori[LogIn.LogInID].Puncte;
            corectanswear += points;

            utilizatoriTableAdapter.UpdateQueryPuncte(corectanswear, Iduser);
            utilizatoriTableAdapter.Fill(utilizatoriDataSet.Utilizatori);
            button1.Visible = false;
            textBox2.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
            checkBox11.Enabled = false;
            checkBox12.Enabled = false;
            checkBox13.Enabled = false;
            checkBox14.Enabled = false;
            checkBox15.Enabled = false;
            checkBox16.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox3.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.utilizatoriDataSet);

        }

        private void Quiz2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilizatoriDataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.utilizatoriDataSet.Utilizatori);

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox6.Checked = false;
                checkBox5.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox5.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox9.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox10.Checked = false;
                checkBox9.Checked = false;
                checkBox12.Checked = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                checkBox13.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox14.Checked = false;
                checkBox13.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox13.Checked = false;
            }
        }
    }
}
