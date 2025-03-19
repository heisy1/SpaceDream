namespace SpaceDream
{
    partial class Leaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard));
            this.utilizatoriDataGridView = new System.Windows.Forms.DataGridView();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriDataSet = new SpaceDream.UtilizatoriDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.utilizatoriTableAdapter = new SpaceDream.UtilizatoriDataSetTableAdapters.UtilizatoriTableAdapter();
            this.tableAdapterManager = new SpaceDream.UtilizatoriDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // utilizatoriDataGridView
            // 
            this.utilizatoriDataGridView.AllowUserToAddRows = false;
            this.utilizatoriDataGridView.AllowUserToDeleteRows = false;
            this.utilizatoriDataGridView.AllowUserToResizeColumns = false;
            this.utilizatoriDataGridView.AllowUserToResizeRows = false;
            this.utilizatoriDataGridView.AutoGenerateColumns = false;
            this.utilizatoriDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.utilizatoriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utilizatoriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.utilizatoriDataGridView.DataSource = this.utilizatoriBindingSource;
            this.utilizatoriDataGridView.GridColor = System.Drawing.Color.Orange;
            this.utilizatoriDataGridView.Location = new System.Drawing.Point(339, 94);
            this.utilizatoriDataGridView.Name = "utilizatoriDataGridView";
            this.utilizatoriDataGridView.Size = new System.Drawing.Size(242, 334);
            this.utilizatoriDataGridView.TabIndex = 0;
            this.utilizatoriDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.utilizatoriDataGridView_CellContentClick);
            this.utilizatoriDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.utilizatoriDataGridView_RowPostPaint);
            // 
            // utilizatoriBindingSource
            // 
            this.utilizatoriBindingSource.DataMember = "Utilizatori";
            this.utilizatoriBindingSource.DataSource = this.utilizatoriDataSet;
            // 
            // utilizatoriDataSet
            // 
            this.utilizatoriDataSet.DataSetName = "UtilizatoriDataSet";
            this.utilizatoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(796, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "GO BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nume utilizator";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nume utilizator";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Puncte";
            this.dataGridViewTextBoxColumn2.HeaderText = "Puncte";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 574);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.utilizatoriDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UtilizatoriDataSet utilizatoriDataSet;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private UtilizatoriDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private UtilizatoriDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView utilizatoriDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}