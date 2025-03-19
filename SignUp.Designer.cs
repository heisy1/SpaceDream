namespace SpaceDream
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.NumeutilizatorSu = new System.Windows.Forms.Label();
            this.ParolaSu = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.txtBoxParola = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.InscrieteSu = new System.Windows.Forms.Button();
            this.InapoiSu = new System.Windows.Forms.Button();
            this.utilizatoriDataSet = new SpaceDream.UtilizatoriDataSet();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriTableAdapter = new SpaceDream.UtilizatoriDataSetTableAdapters.UtilizatoriTableAdapter();
            this.tableAdapterManager = new SpaceDream.UtilizatoriDataSetTableAdapters.TableAdapterManager();
            this.checkBxArataparola = new System.Windows.Forms.CheckBox();
            this.utilizatoriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NumeutilizatorSu
            // 
            this.NumeutilizatorSu.AutoSize = true;
            this.NumeutilizatorSu.BackColor = System.Drawing.Color.Transparent;
            this.NumeutilizatorSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeutilizatorSu.ForeColor = System.Drawing.Color.White;
            this.NumeutilizatorSu.Location = new System.Drawing.Point(143, 100);
            this.NumeutilizatorSu.Name = "NumeutilizatorSu";
            this.NumeutilizatorSu.Size = new System.Drawing.Size(173, 29);
            this.NumeutilizatorSu.TabIndex = 0;
            this.NumeutilizatorSu.Text = "Nume utilizator";
            // 
            // ParolaSu
            // 
            this.ParolaSu.AutoSize = true;
            this.ParolaSu.BackColor = System.Drawing.Color.Transparent;
            this.ParolaSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParolaSu.ForeColor = System.Drawing.Color.White;
            this.ParolaSu.Location = new System.Drawing.Point(205, 197);
            this.ParolaSu.Name = "ParolaSu";
            this.ParolaSu.Size = new System.Drawing.Size(83, 29);
            this.ParolaSu.TabIndex = 1;
            this.ParolaSu.Text = "Parola";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(226, 288);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(82, 29);
            this.Email.TabIndex = 2;
            this.Email.Text = "E-mail";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNume.Location = new System.Drawing.Point(398, 100);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(125, 26);
            this.textBoxNume.TabIndex = 3;
            // 
            // txtBoxParola
            // 
            this.txtBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxParola.Location = new System.Drawing.Point(398, 197);
            this.txtBoxParola.Name = "txtBoxParola";
            this.txtBoxParola.PasswordChar = '*';
            this.txtBoxParola.Size = new System.Drawing.Size(125, 26);
            this.txtBoxParola.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(398, 291);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(125, 26);
            this.textBoxEmail.TabIndex = 5;
            // 
            // InscrieteSu
            // 
            this.InscrieteSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InscrieteSu.Location = new System.Drawing.Point(242, 413);
            this.InscrieteSu.Name = "InscrieteSu";
            this.InscrieteSu.Size = new System.Drawing.Size(150, 37);
            this.InscrieteSu.TabIndex = 6;
            this.InscrieteSu.Text = "Creaza cont";
            this.InscrieteSu.UseVisualStyleBackColor = true;
            this.InscrieteSu.Click += new System.EventHandler(this.InscrieteSu_Click);
            // 
            // InapoiSu
            // 
            this.InapoiSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InapoiSu.Location = new System.Drawing.Point(507, 413);
            this.InapoiSu.Name = "InapoiSu";
            this.InapoiSu.Size = new System.Drawing.Size(150, 37);
            this.InapoiSu.TabIndex = 8;
            this.InapoiSu.Text = "Inapoi";
            this.InapoiSu.UseVisualStyleBackColor = true;
            this.InapoiSu.Click += new System.EventHandler(this.InapoiSu_Click);
            // 
            // utilizatoriDataSet
            // 
            this.utilizatoriDataSet.DataSetName = "UtilizatoriDataSet";
            this.utilizatoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatoriBindingSource
            // 
            this.utilizatoriBindingSource.DataMember = "Utilizatori";
            this.utilizatoriBindingSource.DataSource = this.utilizatoriDataSet;
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SpaceDream.UtilizatoriDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatoriTableAdapter = this.utilizatoriTableAdapter;
            // 
            // checkBxArataparola
            // 
            this.checkBxArataparola.AutoSize = true;
            this.checkBxArataparola.BackColor = System.Drawing.Color.Transparent;
            this.checkBxArataparola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBxArataparola.ForeColor = System.Drawing.Color.White;
            this.checkBxArataparola.Location = new System.Drawing.Point(398, 229);
            this.checkBxArataparola.Name = "checkBxArataparola";
            this.checkBxArataparola.Size = new System.Drawing.Size(95, 17);
            this.checkBxArataparola.TabIndex = 10;
            this.checkBxArataparola.Text = "Arata parola";
            this.checkBxArataparola.UseVisualStyleBackColor = false;
            this.checkBxArataparola.CheckedChanged += new System.EventHandler(this.checkBxArataparola_CheckedChanged);
            // 
            // utilizatoriDataGridView
            // 
            this.utilizatoriDataGridView.AutoGenerateColumns = false;
            this.utilizatoriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utilizatoriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.utilizatoriDataGridView.DataSource = this.utilizatoriBindingSource;
            this.utilizatoriDataGridView.Location = new System.Drawing.Point(654, 187);
            this.utilizatoriDataGridView.Name = "utilizatoriDataGridView";
            this.utilizatoriDataGridView.Size = new System.Drawing.Size(258, 220);
            this.utilizatoriDataGridView.TabIndex = 10;
            this.utilizatoriDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume utilizator";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume utilizator";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Parola";
            this.dataGridViewTextBoxColumn3.HeaderText = "Parola";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pozadeprofil";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pozadeprofil";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Puncte";
            this.dataGridViewTextBoxColumn6.HeaderText = "Puncte";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 535);
            this.Controls.Add(this.utilizatoriDataGridView);
            this.Controls.Add(this.checkBxArataparola);
            this.Controls.Add(this.InapoiSu);
            this.Controls.Add(this.InscrieteSu);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.txtBoxParola);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.ParolaSu);
            this.Controls.Add(this.NumeutilizatorSu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.Text = "SpaceDream";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeutilizatorSu;
        private System.Windows.Forms.Label ParolaSu;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox txtBoxParola;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button InscrieteSu;
        private System.Windows.Forms.Button InapoiSu;
        private UtilizatoriDataSet utilizatoriDataSet;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private UtilizatoriDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private UtilizatoriDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox checkBxArataparola;
        private System.Windows.Forms.DataGridView utilizatoriDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}