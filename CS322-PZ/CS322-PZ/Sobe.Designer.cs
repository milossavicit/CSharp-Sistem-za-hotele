namespace CS322_PZ
{
    partial class Sobe
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
            System.Windows.Forms.Label br_krevetaLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label opisLabel;
            System.Windows.Forms.Label slobodnaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobe));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.sobeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new CS322_PZ.BazaDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDsobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brkrevetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slobodnaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sobeTableAdapter = new CS322_PZ.BazaDataSetTableAdapters.SobeTableAdapter();
            this.tableAdapterManager = new CS322_PZ.BazaDataSetTableAdapters.TableAdapterManager();
            this.br_krevetaTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.slobodnaCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            br_krevetaLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            opisLabel = new System.Windows.Forms.Label();
            slobodnaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // br_krevetaLabel
            // 
            br_krevetaLabel.AutoSize = true;
            br_krevetaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            br_krevetaLabel.Location = new System.Drawing.Point(14, 48);
            br_krevetaLabel.Name = "br_krevetaLabel";
            br_krevetaLabel.Size = new System.Drawing.Size(81, 17);
            br_krevetaLabel.TabIndex = 2;
            br_krevetaLabel.Text = "Br. kreveta:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cenaLabel.Location = new System.Drawing.Point(14, 86);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(45, 17);
            cenaLabel.TabIndex = 4;
            cenaLabel.Text = "Cena:";
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            opisLabel.Location = new System.Drawing.Point(14, 125);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new System.Drawing.Size(41, 17);
            opisLabel.TabIndex = 6;
            opisLabel.Text = "Opis:";
            // 
            // slobodnaLabel
            // 
            slobodnaLabel.AutoSize = true;
            slobodnaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            slobodnaLabel.Location = new System.Drawing.Point(14, 159);
            slobodnaLabel.Name = "slobodnaLabel";
            slobodnaLabel.Size = new System.Drawing.Size(72, 17);
            slobodnaLabel.TabIndex = 8;
            slobodnaLabel.Text = "Slobodna:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.sobeBindingSource;
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
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(794, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // sobeBindingSource
            // 
            this.sobeBindingSource.DataMember = "Sobe";
            this.sobeBindingSource.DataSource = this.bazaDataSet;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDsobeDataGridViewTextBoxColumn,
            this.brkrevetaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.slobodnaDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.sobeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(239, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 362);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDsobeDataGridViewTextBoxColumn
            // 
            this.iDsobeDataGridViewTextBoxColumn.DataPropertyName = "ID_sobe";
            this.iDsobeDataGridViewTextBoxColumn.HeaderText = "ID Sobe";
            this.iDsobeDataGridViewTextBoxColumn.Name = "iDsobeDataGridViewTextBoxColumn";
            this.iDsobeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brkrevetaDataGridViewTextBoxColumn
            // 
            this.brkrevetaDataGridViewTextBoxColumn.DataPropertyName = "br_kreveta";
            this.brkrevetaDataGridViewTextBoxColumn.HeaderText = "Br. kreveta";
            this.brkrevetaDataGridViewTextBoxColumn.Name = "brkrevetaDataGridViewTextBoxColumn";
            this.brkrevetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slobodnaDataGridViewCheckBoxColumn
            // 
            this.slobodnaDataGridViewCheckBoxColumn.DataPropertyName = "slobodna";
            this.slobodnaDataGridViewCheckBoxColumn.HeaderText = "Slobodna";
            this.slobodnaDataGridViewCheckBoxColumn.Name = "slobodnaDataGridViewCheckBoxColumn";
            this.slobodnaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sobeTableAdapter
            // 
            this.sobeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GostiTableAdapter = null;
            this.tableAdapterManager.KorisniciTableAdapter = null;
            this.tableAdapterManager.RezervacijaTableAdapter = null;
            this.tableAdapterManager.SobeTableAdapter = this.sobeTableAdapter;
            this.tableAdapterManager.TransakcijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CS322_PZ.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // br_krevetaTextBox
            // 
            this.br_krevetaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sobeBindingSource, "br_kreveta", true));
            this.br_krevetaTextBox.Location = new System.Drawing.Point(101, 47);
            this.br_krevetaTextBox.Name = "br_krevetaTextBox";
            this.br_krevetaTextBox.Size = new System.Drawing.Size(100, 20);
            this.br_krevetaTextBox.TabIndex = 3;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sobeBindingSource, "cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(101, 85);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cenaTextBox.TabIndex = 5;
            // 
            // opisTextBox
            // 
            this.opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sobeBindingSource, "opis", true));
            this.opisTextBox.Location = new System.Drawing.Point(101, 124);
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(100, 20);
            this.opisTextBox.TabIndex = 7;
            // 
            // slobodnaCheckBox
            // 
            this.slobodnaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sobeBindingSource, "slobodna", true));
            this.slobodnaCheckBox.Enabled = false;
            this.slobodnaCheckBox.Location = new System.Drawing.Point(101, 156);
            this.slobodnaCheckBox.Name = "slobodnaCheckBox";
            this.slobodnaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.slobodnaCheckBox.TabIndex = 9;
            this.slobodnaCheckBox.UseVisualStyleBackColor = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CS322_PZ.Properties.Resources.save;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Sobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 421);
            this.Controls.Add(slobodnaLabel);
            this.Controls.Add(this.slobodnaCheckBox);
            this.Controls.Add(opisLabel);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(br_krevetaLabel);
            this.Controls.Add(this.br_krevetaTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sobe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobe";
            this.Load += new System.EventHandler(this.Sobe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource sobeBindingSource;
        private BazaDataSetTableAdapters.SobeTableAdapter sobeTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox br_krevetaTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.CheckBox slobodnaCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDsobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brkrevetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn slobodnaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}