namespace CS322_PZ
{
    partial class Transakcije
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
            System.Windows.Forms.Label iD_transakcijeLabel;
            System.Windows.Forms.Label iD_rezervacijeLabel;
            System.Windows.Forms.Label iznosLabel;
            System.Windows.Forms.Label nacin_placanjaLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label tip_karticeLabel;
            System.Windows.Forms.Label vazi_doLabel;
            System.Windows.Forms.Label cvvLabel;
            System.Windows.Forms.Label br_karticeLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transakcije));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iD_transakcijeTextBox = new System.Windows.Forms.TextBox();
            this.iD_rezervacijeTextBox = new System.Windows.Forms.TextBox();
            this.iznosTextBox = new System.Windows.Forms.TextBox();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vazi_doTextBox = new System.Windows.Forms.TextBox();
            this.cvvTextBox = new System.Windows.Forms.TextBox();
            this.br_karticeTextBox = new System.Windows.Forms.TextBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            iD_transakcijeLabel = new System.Windows.Forms.Label();
            iD_rezervacijeLabel = new System.Windows.Forms.Label();
            iznosLabel = new System.Windows.Forms.Label();
            nacin_placanjaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            tip_karticeLabel = new System.Windows.Forms.Label();
            vazi_doLabel = new System.Windows.Forms.Label();
            cvvLabel = new System.Windows.Forms.Label();
            br_karticeLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iD_transakcijeLabel
            // 
            iD_transakcijeLabel.AutoSize = true;
            iD_transakcijeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_transakcijeLabel.Location = new System.Drawing.Point(176, 37);
            iD_transakcijeLabel.Name = "iD_transakcijeLabel";
            iD_transakcijeLabel.Size = new System.Drawing.Size(58, 17);
            iD_transakcijeLabel.TabIndex = 2;
            iD_transakcijeLabel.Text = "ID tran.:";
            // 
            // iD_transakcijeTextBox
            // 
            this.iD_transakcijeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_transakcijeTextBox.Location = new System.Drawing.Point(287, 34);
            this.iD_transakcijeTextBox.Name = "iD_transakcijeTextBox";
            this.iD_transakcijeTextBox.ReadOnly = true;
            this.iD_transakcijeTextBox.Size = new System.Drawing.Size(200, 23);
            this.iD_transakcijeTextBox.TabIndex = 3;
            // 
            // iD_rezervacijeLabel
            // 
            iD_rezervacijeLabel.AutoSize = true;
            iD_rezervacijeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_rezervacijeLabel.Location = new System.Drawing.Point(176, 66);
            iD_rezervacijeLabel.Name = "iD_rezervacijeLabel";
            iD_rezervacijeLabel.Size = new System.Drawing.Size(53, 17);
            iD_rezervacijeLabel.TabIndex = 4;
            iD_rezervacijeLabel.Text = "ID rez.:";
            // 
            // iD_rezervacijeTextBox
            // 
            this.iD_rezervacijeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_rezervacijeTextBox.Location = new System.Drawing.Point(287, 63);
            this.iD_rezervacijeTextBox.Name = "iD_rezervacijeTextBox";
            this.iD_rezervacijeTextBox.ReadOnly = true;
            this.iD_rezervacijeTextBox.Size = new System.Drawing.Size(200, 23);
            this.iD_rezervacijeTextBox.TabIndex = 5;
            // 
            // iznosLabel
            // 
            iznosLabel.AutoSize = true;
            iznosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iznosLabel.Location = new System.Drawing.Point(176, 95);
            iznosLabel.Name = "iznosLabel";
            iznosLabel.Size = new System.Drawing.Size(45, 17);
            iznosLabel.TabIndex = 6;
            iznosLabel.Text = "Iznos:";
            // 
            // iznosTextBox
            // 
            this.iznosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iznosTextBox.Location = new System.Drawing.Point(287, 92);
            this.iznosTextBox.Name = "iznosTextBox";
            this.iznosTextBox.ReadOnly = true;
            this.iznosTextBox.Size = new System.Drawing.Size(200, 23);
            this.iznosTextBox.TabIndex = 7;
            // 
            // nacin_placanjaLabel
            // 
            nacin_placanjaLabel.AutoSize = true;
            nacin_placanjaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nacin_placanjaLabel.Location = new System.Drawing.Point(176, 124);
            nacin_placanjaLabel.Name = "nacin_placanjaLabel";
            nacin_placanjaLabel.Size = new System.Drawing.Size(105, 17);
            nacin_placanjaLabel.TabIndex = 8;
            nacin_placanjaLabel.Text = "Način plaćanja:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datumLabel.Location = new System.Drawing.Point(176, 155);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(53, 17);
            datumLabel.TabIndex = 10;
            datumLabel.Text = "Datum:";
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumDateTimePicker.Location = new System.Drawing.Point(287, 150);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.datumDateTimePicker.TabIndex = 11;
            // 
            // tip_karticeLabel
            // 
            tip_karticeLabel.AutoSize = true;
            tip_karticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tip_karticeLabel.Location = new System.Drawing.Point(539, 37);
            tip_karticeLabel.Name = "tip_karticeLabel";
            tip_karticeLabel.Size = new System.Drawing.Size(78, 17);
            tip_karticeLabel.TabIndex = 12;
            tip_karticeLabel.Text = "Tip kartice:";
            // 
            // vazi_doLabel
            // 
            vazi_doLabel.AutoSize = true;
            vazi_doLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vazi_doLabel.Location = new System.Drawing.Point(539, 66);
            vazi_doLabel.Name = "vazi_doLabel";
            vazi_doLabel.Size = new System.Drawing.Size(59, 17);
            vazi_doLabel.TabIndex = 14;
            vazi_doLabel.Text = "Važi do:";
            // 
            // vazi_doTextBox
            // 
            this.vazi_doTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vazi_doTextBox.Location = new System.Drawing.Point(624, 63);
            this.vazi_doTextBox.Name = "vazi_doTextBox";
            this.vazi_doTextBox.Size = new System.Drawing.Size(200, 23);
            this.vazi_doTextBox.TabIndex = 15;
            // 
            // cvvLabel
            // 
            cvvLabel.AutoSize = true;
            cvvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cvvLabel.Location = new System.Drawing.Point(539, 95);
            cvvLabel.Name = "cvvLabel";
            cvvLabel.Size = new System.Drawing.Size(39, 17);
            cvvLabel.TabIndex = 16;
            cvvLabel.Text = "CVV:";
            // 
            // cvvTextBox
            // 
            this.cvvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvvTextBox.Location = new System.Drawing.Point(624, 92);
            this.cvvTextBox.Name = "cvvTextBox";
            this.cvvTextBox.Size = new System.Drawing.Size(200, 23);
            this.cvvTextBox.TabIndex = 17;
            // 
            // br_karticeLabel
            // 
            br_karticeLabel.AutoSize = true;
            br_karticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            br_karticeLabel.Location = new System.Drawing.Point(539, 124);
            br_karticeLabel.Name = "br_karticeLabel";
            br_karticeLabel.Size = new System.Drawing.Size(76, 17);
            br_karticeLabel.TabIndex = 18;
            br_karticeLabel.Text = "Br. kartice:";
            // 
            // br_karticeTextBox
            // 
            this.br_karticeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_karticeTextBox.Location = new System.Drawing.Point(624, 121);
            this.br_karticeTextBox.Name = "br_karticeTextBox";
            this.br_karticeTextBox.Size = new System.Drawing.Size(200, 23);
            this.br_karticeTextBox.TabIndex = 19;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(539, 155);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 17);
            statusLabel.TabIndex = 20;
            statusLabel.Text = "Status:";
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCheckBox.Location = new System.Drawing.Point(624, 150);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(200, 24);
            this.statusCheckBox.TabIndex = 21;
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(475, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Ažuriraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(624, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 24);
            this.comboBox2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(830, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "e.g. 01/2018";
            // 
            // Transakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_transakcijeLabel);
            this.Controls.Add(this.iD_transakcijeTextBox);
            this.Controls.Add(iD_rezervacijeLabel);
            this.Controls.Add(this.iD_rezervacijeTextBox);
            this.Controls.Add(iznosLabel);
            this.Controls.Add(this.iznosTextBox);
            this.Controls.Add(nacin_placanjaLabel);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(tip_karticeLabel);
            this.Controls.Add(vazi_doLabel);
            this.Controls.Add(this.vazi_doTextBox);
            this.Controls.Add(cvvLabel);
            this.Controls.Add(this.cvvTextBox);
            this.Controls.Add(br_karticeLabel);
            this.Controls.Add(this.br_karticeTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transakcije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transakcije";
            this.Load += new System.EventHandler(this.Transakcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox iD_transakcijeTextBox;
        private System.Windows.Forms.TextBox iD_rezervacijeTextBox;
        private System.Windows.Forms.TextBox iznosTextBox;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.TextBox vazi_doTextBox;
        private System.Windows.Forms.TextBox cvvTextBox;
        private System.Windows.Forms.TextBox br_karticeTextBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}