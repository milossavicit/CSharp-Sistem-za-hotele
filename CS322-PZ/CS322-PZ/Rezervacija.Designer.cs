namespace CS322_PZ
{
    partial class Rezervacija
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
            System.Windows.Forms.Label br_gostijuLabel;
            System.Windows.Forms.Label dolazakLabel;
            System.Windows.Forms.Label odlazakLabel;
            System.Windows.Forms.Label iD_gostaLabel;
            System.Windows.Forms.Label iD_sobeLabel;
            System.Windows.Forms.Label iD_rezervacijeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezervacija));
            this.dolazakDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.odlazakDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.iD_rezervacijeTextBox = new System.Windows.Forms.TextBox();
            this.iD_gostaComboBox = new System.Windows.Forms.ComboBox();
            this.imeGostalabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.br_gostijuTextBox = new System.Windows.Forms.TextBox();
            br_gostijuLabel = new System.Windows.Forms.Label();
            dolazakLabel = new System.Windows.Forms.Label();
            odlazakLabel = new System.Windows.Forms.Label();
            iD_gostaLabel = new System.Windows.Forms.Label();
            iD_sobeLabel = new System.Windows.Forms.Label();
            iD_rezervacijeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // br_gostijuLabel
            // 
            br_gostijuLabel.AutoSize = true;
            br_gostijuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            br_gostijuLabel.Location = new System.Drawing.Point(98, 66);
            br_gostijuLabel.Name = "br_gostijuLabel";
            br_gostijuLabel.Size = new System.Drawing.Size(75, 17);
            br_gostijuLabel.TabIndex = 3;
            br_gostijuLabel.Text = "Br. gostiju:";
            // 
            // dolazakLabel
            // 
            dolazakLabel.AutoSize = true;
            dolazakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dolazakLabel.Location = new System.Drawing.Point(98, 98);
            dolazakLabel.Name = "dolazakLabel";
            dolazakLabel.Size = new System.Drawing.Size(63, 17);
            dolazakLabel.TabIndex = 5;
            dolazakLabel.Text = "Dolazak:";
            // 
            // odlazakLabel
            // 
            odlazakLabel.AutoSize = true;
            odlazakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            odlazakLabel.Location = new System.Drawing.Point(98, 127);
            odlazakLabel.Name = "odlazakLabel";
            odlazakLabel.Size = new System.Drawing.Size(64, 17);
            odlazakLabel.TabIndex = 7;
            odlazakLabel.Text = "Odlazak:";
            // 
            // iD_gostaLabel
            // 
            iD_gostaLabel.AutoSize = true;
            iD_gostaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_gostaLabel.Location = new System.Drawing.Point(98, 154);
            iD_gostaLabel.Name = "iD_gostaLabel";
            iD_gostaLabel.Size = new System.Drawing.Size(64, 17);
            iD_gostaLabel.TabIndex = 9;
            iD_gostaLabel.Text = "ID gosta:";
            // 
            // iD_sobeLabel
            // 
            iD_sobeLabel.AutoSize = true;
            iD_sobeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_sobeLabel.Location = new System.Drawing.Point(98, 184);
            iD_sobeLabel.Name = "iD_sobeLabel";
            iD_sobeLabel.Size = new System.Drawing.Size(60, 17);
            iD_sobeLabel.TabIndex = 11;
            iD_sobeLabel.Text = "ID sobe:";
            // 
            // iD_rezervacijeLabel
            // 
            iD_rezervacijeLabel.AutoSize = true;
            iD_rezervacijeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_rezervacijeLabel.Location = new System.Drawing.Point(98, 36);
            iD_rezervacijeLabel.Name = "iD_rezervacijeLabel";
            iD_rezervacijeLabel.Size = new System.Drawing.Size(53, 17);
            iD_rezervacijeLabel.TabIndex = 19;
            iD_rezervacijeLabel.Text = "ID rez.:";
            // 
            // dolazakDateTimePicker
            // 
            this.dolazakDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolazakDateTimePicker.Location = new System.Drawing.Point(182, 93);
            this.dolazakDateTimePicker.Name = "dolazakDateTimePicker";
            this.dolazakDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dolazakDateTimePicker.TabIndex = 6;
            // 
            // odlazakDateTimePicker
            // 
            this.odlazakDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odlazakDateTimePicker.Location = new System.Drawing.Point(182, 122);
            this.odlazakDateTimePicker.Name = "odlazakDateTimePicker";
            this.odlazakDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.odlazakDateTimePicker.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(529, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(529, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "Obriši";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(182, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 24);
            this.comboBox2.TabIndex = 19;
            // 
            // iD_rezervacijeTextBox
            // 
            this.iD_rezervacijeTextBox.Enabled = false;
            this.iD_rezervacijeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_rezervacijeTextBox.Location = new System.Drawing.Point(182, 33);
            this.iD_rezervacijeTextBox.Name = "iD_rezervacijeTextBox";
            this.iD_rezervacijeTextBox.Size = new System.Drawing.Size(200, 23);
            this.iD_rezervacijeTextBox.TabIndex = 20;
            // 
            // iD_gostaComboBox
            // 
            this.iD_gostaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_gostaComboBox.FormattingEnabled = true;
            this.iD_gostaComboBox.Location = new System.Drawing.Point(182, 151);
            this.iD_gostaComboBox.Name = "iD_gostaComboBox";
            this.iD_gostaComboBox.Size = new System.Drawing.Size(200, 24);
            this.iD_gostaComboBox.TabIndex = 23;
            this.iD_gostaComboBox.ValueMember = "ID_gosta";
            // 
            // imeGostalabel
            // 
            this.imeGostalabel.AutoSize = true;
            this.imeGostalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeGostalabel.Location = new System.Drawing.Point(388, 154);
            this.imeGostalabel.Name = "imeGostalabel";
            this.imeGostalabel.Size = new System.Drawing.Size(0, 17);
            this.imeGostalabel.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(696, 236);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // br_gostijuTextBox
            // 
            this.br_gostijuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_gostijuTextBox.Location = new System.Drawing.Point(182, 63);
            this.br_gostijuTextBox.Name = "br_gostijuTextBox";
            this.br_gostijuTextBox.Size = new System.Drawing.Size(200, 23);
            this.br_gostijuTextBox.TabIndex = 26;
            // 
            // Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 488);
            this.Controls.Add(this.br_gostijuTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.imeGostalabel);
            this.Controls.Add(this.iD_gostaComboBox);
            this.Controls.Add(iD_rezervacijeLabel);
            this.Controls.Add(this.iD_rezervacijeTextBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(br_gostijuLabel);
            this.Controls.Add(dolazakLabel);
            this.Controls.Add(this.dolazakDateTimePicker);
            this.Controls.Add(odlazakLabel);
            this.Controls.Add(this.odlazakDateTimePicker);
            this.Controls.Add(iD_gostaLabel);
            this.Controls.Add(iD_sobeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.Rezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dolazakDateTimePicker;
        private System.Windows.Forms.DateTimePicker odlazakDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox iD_rezervacijeTextBox;
        private System.Windows.Forms.ComboBox iD_gostaComboBox;
        private System.Windows.Forms.Label imeGostalabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox br_gostijuTextBox;
    }
}