﻿namespace SpaceDream
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Autentificare = new System.Windows.Forms.Label();
            this.NumeUtilizator = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.Conectare = new System.Windows.Forms.Button();
            this.Iesire = new System.Windows.Forms.Button();
            this.Nuaicont = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.utilizatoriDataSet = new SpaceDream.UtilizatoriDataSet();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriTableAdapter = new SpaceDream.UtilizatoriDataSetTableAdapters.UtilizatoriTableAdapter();
            this.tableAdapterManager = new SpaceDream.UtilizatoriDataSetTableAdapters.TableAdapterManager();
            this.utilizatoriBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.utilizatoriBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingNavigator)).BeginInit();
            this.utilizatoriBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Autentificare
            // 
            this.Autentificare.AutoSize = true;
            this.Autentificare.BackColor = System.Drawing.Color.Transparent;
            this.Autentificare.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autentificare.ForeColor = System.Drawing.Color.Magenta;
            this.Autentificare.Location = new System.Drawing.Point(360, 18);
            this.Autentificare.Name = "Autentificare";
            this.Autentificare.Size = new System.Drawing.Size(218, 45);
            this.Autentificare.TabIndex = 0;
            this.Autentificare.Text = "Autentificare";
            this.Autentificare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumeUtilizator
            // 
            this.NumeUtilizator.AutoSize = true;
            this.NumeUtilizator.BackColor = System.Drawing.Color.Transparent;
            this.NumeUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeUtilizator.ForeColor = System.Drawing.Color.White;
            this.NumeUtilizator.Location = new System.Drawing.Point(111, 151);
            this.NumeUtilizator.Name = "NumeUtilizator";
            this.NumeUtilizator.Size = new System.Drawing.Size(188, 29);
            this.NumeUtilizator.TabIndex = 1;
            this.NumeUtilizator.Text = "Nume utilizator";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.BackColor = System.Drawing.Color.Transparent;
            this.Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parola.ForeColor = System.Drawing.Color.White;
            this.Parola.Location = new System.Drawing.Point(201, 246);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(89, 29);
            this.Parola.TabIndex = 2;
            this.Parola.Text = "Parola";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNume.Location = new System.Drawing.Point(406, 155);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(123, 26);
            this.textBoxNume.TabIndex = 3;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParola.Location = new System.Drawing.Point(406, 246);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(123, 26);
            this.textBoxParola.TabIndex = 4;
            // 
            // Conectare
            // 
            this.Conectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conectare.Location = new System.Drawing.Point(225, 404);
            this.Conectare.Name = "Conectare";
            this.Conectare.Size = new System.Drawing.Size(150, 37);
            this.Conectare.TabIndex = 5;
            this.Conectare.Text = "Conectare";
            this.Conectare.UseVisualStyleBackColor = true;
            this.Conectare.Click += new System.EventHandler(this.Conectare_Click);
            // 
            // Iesire
            // 
            this.Iesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iesire.Location = new System.Drawing.Point(559, 405);
            this.Iesire.Name = "Iesire";
            this.Iesire.Size = new System.Drawing.Size(150, 36);
            this.Iesire.TabIndex = 6;
            this.Iesire.Text = "Iesire";
            this.Iesire.UseVisualStyleBackColor = true;
            this.Iesire.Click += new System.EventHandler(this.Iesire_Click);
            // 
            // Nuaicont
            // 
            this.Nuaicont.AutoSize = true;
            this.Nuaicont.BackColor = System.Drawing.Color.Transparent;
            this.Nuaicont.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuaicont.ForeColor = System.Drawing.Color.GreenYellow;
            this.Nuaicont.Location = new System.Drawing.Point(391, 446);
            this.Nuaicont.Name = "Nuaicont";
            this.Nuaicont.Size = new System.Drawing.Size(153, 28);
            this.Nuaicont.TabIndex = 7;
            this.Nuaicont.Text = "Nu ai cont ? ";
            this.Nuaicont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(388, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inregistreaza-te";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // utilizatoriBindingNavigator
            // 
            this.utilizatoriBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.utilizatoriBindingNavigator.BindingSource = this.utilizatoriBindingSource;
            this.utilizatoriBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.utilizatoriBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.utilizatoriBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.utilizatoriBindingNavigatorSaveItem});
            this.utilizatoriBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.utilizatoriBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.utilizatoriBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.utilizatoriBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.utilizatoriBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.utilizatoriBindingNavigator.Name = "utilizatoriBindingNavigator";
            this.utilizatoriBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.utilizatoriBindingNavigator.Size = new System.Drawing.Size(959, 25);
            this.utilizatoriBindingNavigator.TabIndex = 9;
            this.utilizatoriBindingNavigator.Text = "bindingNavigator1";
            this.utilizatoriBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // utilizatoriBindingNavigatorSaveItem
            // 
            this.utilizatoriBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.utilizatoriBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("utilizatoriBindingNavigatorSaveItem.Image")));
            this.utilizatoriBindingNavigatorSaveItem.Name = "utilizatoriBindingNavigatorSaveItem";
            this.utilizatoriBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.utilizatoriBindingNavigatorSaveItem.Text = "Save Data";
            this.utilizatoriBindingNavigatorSaveItem.Click += new System.EventHandler(this.utilizatoriBindingNavigatorSaveItem_Click);
            // 
            // checkBxArataparola
            // 
            this.checkBxArataparola.AutoSize = true;
            this.checkBxArataparola.BackColor = System.Drawing.Color.Transparent;
            this.checkBxArataparola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBxArataparola.ForeColor = System.Drawing.Color.White;
            this.checkBxArataparola.Location = new System.Drawing.Point(405, 281);
            this.checkBxArataparola.Name = "checkBxArataparola";
            this.checkBxArataparola.Size = new System.Drawing.Size(95, 17);
            this.checkBxArataparola.TabIndex = 11;
            this.checkBxArataparola.Text = "Arata parola";
            this.checkBxArataparola.UseVisualStyleBackColor = false;
            this.checkBxArataparola.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // utilizatoriDataGridView
            // 
            this.utilizatoriDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.utilizatoriDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.utilizatoriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utilizatoriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.utilizatoriDataGridView.DataSource = this.utilizatoriBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.utilizatoriDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.utilizatoriDataGridView.Location = new System.Drawing.Point(602, 119);
            this.utilizatoriDataGridView.Name = "utilizatoriDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.utilizatoriDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.utilizatoriDataGridView.Size = new System.Drawing.Size(300, 220);
            this.utilizatoriDataGridView.TabIndex = 11;
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
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 535);
            this.Controls.Add(this.utilizatoriDataGridView);
            this.Controls.Add(this.checkBxArataparola);
            this.Controls.Add(this.utilizatoriBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nuaicont);
            this.Controls.Add(this.Iesire);
            this.Controls.Add(this.Conectare);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.NumeUtilizator);
            this.Controls.Add(this.Autentificare);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LogIn";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SpaceDream";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingNavigator)).EndInit();
            this.utilizatoriBindingNavigator.ResumeLayout(false);
            this.utilizatoriBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Autentificare;
        private System.Windows.Forms.Label NumeUtilizator;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button Conectare;
        private System.Windows.Forms.Button Iesire;
        private System.Windows.Forms.Label Nuaicont;
        private System.Windows.Forms.Label label1;
        private UtilizatoriDataSet utilizatoriDataSet;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private UtilizatoriDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private UtilizatoriDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator utilizatoriBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton utilizatoriBindingNavigatorSaveItem;
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

