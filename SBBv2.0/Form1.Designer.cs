namespace SBBv2._0
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.radioAbfahrt = new System.Windows.Forms.RadioButton();
            this.radioAnkunft = new System.Windows.Forms.RadioButton();
            this.dateTimePickerUhrzeit = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.txtNach = new System.Windows.Forms.TextBox();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(540, 245);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 61);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioAbfahrt
            // 
            this.radioAbfahrt.AutoSize = true;
            this.radioAbfahrt.Location = new System.Drawing.Point(434, 247);
            this.radioAbfahrt.Name = "radioAbfahrt";
            this.radioAbfahrt.Size = new System.Drawing.Size(75, 21);
            this.radioAbfahrt.TabIndex = 25;
            this.radioAbfahrt.TabStop = true;
            this.radioAbfahrt.Text = "Abfahrt";
            this.radioAbfahrt.UseVisualStyleBackColor = true;
            // 
            // radioAnkunft
            // 
            this.radioAnkunft.AutoSize = true;
            this.radioAnkunft.Location = new System.Drawing.Point(434, 285);
            this.radioAnkunft.Name = "radioAnkunft";
            this.radioAnkunft.Size = new System.Drawing.Size(77, 21);
            this.radioAnkunft.TabIndex = 24;
            this.radioAnkunft.TabStop = true;
            this.radioAnkunft.Text = "Ankunft";
            this.radioAnkunft.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerUhrzeit
            // 
            this.dateTimePickerUhrzeit.CustomFormat = "HH:mm tt";
            this.dateTimePickerUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerUhrzeit.Location = new System.Drawing.Point(256, 280);
            this.dateTimePickerUhrzeit.Name = "dateTimePickerUhrzeit";
            this.dateTimePickerUhrzeit.ShowUpDown = true;
            this.dateTimePickerUhrzeit.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerUhrzeit.TabIndex = 23;
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatum.Location = new System.Drawing.Point(67, 280);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerDatum.TabIndex = 22;
            this.dateTimePickerDatum.Value = new System.DateTime(2017, 5, 17, 10, 18, 52, 0);
            // 
            // txtNach
            // 
            this.txtNach.Location = new System.Drawing.Point(434, 154);
            this.txtNach.Name = "txtNach";
            this.txtNach.Size = new System.Drawing.Size(213, 22);
            this.txtNach.TabIndex = 21;
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(67, 154);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(213, 22);
            this.txtVon.TabIndex = 20;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(326, 145);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(65, 41);
            this.btnSwitch.TabIndex = 19;
            this.btnSwitch.Text = "<->";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Uhrzeit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Datum";
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(431, 126);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(41, 17);
            this.lblNach.TabIndex = 16;
            this.lblNach.Text = "Nach";
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(64, 126);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(33, 17);
            this.lblVon.TabIndex = 15;
            this.lblVon.Text = "Von";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "SBB v2.0";
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Nach,
            this.Dauer,
            this.Abfahrt,
            this.Ankunft,
            this.Gleis});
            this.gridView.Location = new System.Drawing.Point(67, 360);
            this.gridView.Name = "gridView";
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(644, 332);
            this.gridView.TabIndex = 27;
            // 
            // Von
            // 
            this.Von.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Von.HeaderText = "Von";
            this.Von.Name = "Von";
            this.Von.Width = 62;
            // 
            // Nach
            // 
            this.Nach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nach.HeaderText = "Nach";
            this.Nach.Name = "Nach";
            this.Nach.Width = 70;
            // 
            // Dauer
            // 
            this.Dauer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.Name = "Dauer";
            this.Dauer.Width = 76;
            // 
            // Abfahrt
            // 
            this.Abfahrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.Width = 83;
            // 
            // Ankunft
            // 
            this.Ankunft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.Name = "Ankunft";
            this.Ankunft.Width = 85;
            // 
            // Gleis
            // 
            this.Gleis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.Name = "Gleis";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(715, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 170);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verbindungen von bestimmter Station aus";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 748);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.radioAbfahrt);
            this.Controls.Add(this.radioAnkunft);
            this.Controls.Add(this.dateTimePickerUhrzeit);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.txtNach);
            this.Controls.Add(this.txtVon);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNach);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SBB v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioAbfahrt;
        private System.Windows.Forms.RadioButton radioAnkunft;
        private System.Windows.Forms.DateTimePicker dateTimePickerUhrzeit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.TextBox txtNach;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

