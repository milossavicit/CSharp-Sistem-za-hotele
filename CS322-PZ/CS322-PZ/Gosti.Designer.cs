namespace CS322_PZ
{
    partial class Gosti
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
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label br_telefonaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label datum_rodjenjaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gosti));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDgostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrodjenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new CS322_PZ.BazaDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gostiTableAdapter = new CS322_PZ.BazaDataSetTableAdapters.GostiTableAdapter();
            this.tableAdapterManager = new CS322_PZ.BazaDataSetTableAdapters.TableAdapterManager();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.br_telefonaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datum_rodjenjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_gostaTextBox = new System.Windows.Forms.TextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            br_telefonaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            datum_rodjenjaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imeLabel.Location = new System.Drawing.Point(7, 27);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(34, 17);
            imeLabel.TabIndex = 4;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prezimeLabel.Location = new System.Drawing.Point(216, 27);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(63, 17);
            prezimeLabel.TabIndex = 6;
            prezimeLabel.Text = "Prezime:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adresaLabel.Location = new System.Drawing.Point(427, 27);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(57, 17);
            adresaLabel.TabIndex = 8;
            adresaLabel.Text = "Adresa:";
            // 
            // br_telefonaLabel
            // 
            br_telefonaLabel.AutoSize = true;
            br_telefonaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            br_telefonaLabel.Location = new System.Drawing.Point(7, 91);
            br_telefonaLabel.Name = "br_telefonaLabel";
            br_telefonaLabel.Size = new System.Drawing.Size(85, 17);
            br_telefonaLabel.TabIndex = 10;
            br_telefonaLabel.Text = "Br. telefona:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(295, 137);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // datum_rodjenjaLabel
            // 
            datum_rodjenjaLabel.AutoSize = true;
            datum_rodjenjaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datum_rodjenjaLabel.Location = new System.Drawing.Point(427, 89);
            datum_rodjenjaLabel.Name = "datum_rodjenjaLabel";
            datum_rodjenjaLabel.Size = new System.Drawing.Size(108, 17);
            datum_rodjenjaLabel.TabIndex = 14;
            datum_rodjenjaLabel.Text = "Datum rodjenja:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDgostaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.brtelefonaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.datumrodjenjaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gostiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDgostaDataGridViewTextBoxColumn
            // 
            this.iDgostaDataGridViewTextBoxColumn.DataPropertyName = "ID_gosta";
            this.iDgostaDataGridViewTextBoxColumn.HeaderText = "ID Gosta";
            this.iDgostaDataGridViewTextBoxColumn.Name = "iDgostaDataGridViewTextBoxColumn";
            this.iDgostaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // brtelefonaDataGridViewTextBoxColumn
            // 
            this.brtelefonaDataGridViewTextBoxColumn.DataPropertyName = "br_telefona";
            this.brtelefonaDataGridViewTextBoxColumn.HeaderText = "Br. telefona";
            this.brtelefonaDataGridViewTextBoxColumn.Name = "brtelefonaDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // datumrodjenjaDataGridViewTextBoxColumn
            // 
            this.datumrodjenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_rodjenja";
            this.datumrodjenjaDataGridViewTextBoxColumn.HeaderText = "Datum rodjenja";
            this.datumrodjenjaDataGridViewTextBoxColumn.Name = "datumrodjenjaDataGridViewTextBoxColumn";
            // 
            // gostiBindingSource
            // 
            this.gostiBindingSource.DataMember = "Gosti";
            this.gostiBindingSource.DataSource = this.bazaDataSet;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.gostiBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton2,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(783, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::CS322_PZ.Properties.Resources.add;
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CS322_PZ.Properties.Resources.save;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // gostiTableAdapter
            // 
            this.gostiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GostiTableAdapter = this.gostiTableAdapter;
            this.tableAdapterManager.KorisniciTableAdapter = null;
            this.tableAdapterManager.RezervacijaTableAdapter = null;
            this.tableAdapterManager.SobeTableAdapter = null;
            this.tableAdapterManager.TransakcijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CS322_PZ.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gostiBindingSource, "Ime", true));
            this.imeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeTextBox.Location = new System.Drawing.Point(10, 47);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(174, 23);
            this.imeTextBox.TabIndex = 5;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gostiBindingSource, "Prezime", true));
            this.prezimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezimeTextBox.Location = new System.Drawing.Point(219, 47);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(174, 23);
            this.prezimeTextBox.TabIndex = 7;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gostiBindingSource, "Adresa", true));
            this.adresaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresaTextBox.Location = new System.Drawing.Point(430, 47);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(174, 23);
            this.adresaTextBox.TabIndex = 9;
            // 
            // br_telefonaTextBox
            // 
            this.br_telefonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gostiBindingSource, "br_telefona", true));
            this.br_telefonaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_telefonaTextBox.Location = new System.Drawing.Point(10, 111);
            this.br_telefonaTextBox.Name = "br_telefonaTextBox";
            this.br_telefonaTextBox.Size = new System.Drawing.Size(174, 23);
            this.br_telefonaTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gostiBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(298, 157);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(174, 23);
            this.emailTextBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(br_telefonaLabel);
            this.groupBox1.Controls.Add(prezimeLabel);
            this.groupBox1.Controls.Add(this.br_telefonaTextBox);
            this.groupBox1.Controls.Add(imeLabel);
            this.groupBox1.Controls.Add(this.prezimeTextBox);
            this.groupBox1.Controls.Add(this.adresaTextBox);
            this.groupBox1.Controls.Add(adresaLabel);
            this.groupBox1.Controls.Add(this.imeTextBox);
            this.groupBox1.Controls.Add(this.datum_rodjenjaDateTimePicker);
            this.groupBox1.Controls.Add(datum_rodjenjaLabel);
            this.groupBox1.Location = new System.Drawing.Point(79, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 172);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gosti";
            // 
            // datum_rodjenjaDateTimePicker
            // 
            this.datum_rodjenjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gostiBindingSource, "datum_rodjenja", true));
            this.datum_rodjenjaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datum_rodjenjaDateTimePicker.Location = new System.Drawing.Point(430, 109);
            this.datum_rodjenjaDateTimePicker.Name = "datum_rodjenjaDateTimePicker";
            this.datum_rodjenjaDateTimePicker.Size = new System.Drawing.Size(174, 23);
            this.datum_rodjenjaDateTimePicker.TabIndex = 29;
            // 
            // iD_gostaTextBox
            // 
            this.iD_gostaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gostiBindingSource, "ID_gosta", true));
            this.iD_gostaTextBox.Location = new System.Drawing.Point(671, 5);
            this.iD_gostaTextBox.Name = "iD_gostaTextBox";
            this.iD_gostaTextBox.ReadOnly = true;
            this.iD_gostaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_gostaTextBox.TabIndex = 17;
            this.iD_gostaTextBox.Visible = false;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::CS322_PZ.Properties.Resources.delete;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Gosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 533);
            this.Controls.Add(this.iD_gostaTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gosti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gosti";
            this.Load += new System.EventHandler(this.Gosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource gostiBindingSource;
        private BazaDataSetTableAdapters.GostiTableAdapter gostiTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDgostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrodjenjaDataGridViewTextBoxColumn;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox br_telefonaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datum_rodjenjaDateTimePicker;
        private System.Windows.Forms.TextBox iD_gostaTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}