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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitel = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchStation = new System.Windows.Forms.Button();
            this.txtVonStation = new System.Windows.Forms.TextBox();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerUhrzeit = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbVon = new System.Windows.Forms.ComboBox();
            this.cmbNach = new System.Windows.Forms.ComboBox();
            this.btnMapsVon = new System.Windows.Forms.Button();
            this.btnMapsNach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(40, 42);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(374, 46);
            this.lblTitel.TabIndex = 14;
            this.lblTitel.Text = "Verbindung suchen:";
            // 
            // gridView
            // 
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Nach,
            this.Dauer,
            this.Abfahrt,
            this.Ankunft,
            this.Gleis});
            this.gridView.Location = new System.Drawing.Point(329, 356);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(604, 329);
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
            this.groupBox1.Controls.Add(this.btnSearchStation);
            this.groupBox1.Controls.Add(this.txtVonStation);
            this.groupBox1.Location = new System.Drawing.Point(689, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 208);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abfahrtstafel von Station anzeigen";
            // 
            // btnSearchStation
            // 
            this.btnSearchStation.Location = new System.Drawing.Point(152, 104);
            this.btnSearchStation.Name = "btnSearchStation";
            this.btnSearchStation.Size = new System.Drawing.Size(136, 41);
            this.btnSearchStation.TabIndex = 1;
            this.btnSearchStation.Text = "Search Station";
            this.btnSearchStation.UseVisualStyleBackColor = true;
            this.btnSearchStation.Click += new System.EventHandler(this.btnSearchStation_Click);
            // 
            // txtVonStation
            // 
            this.txtVonStation.Location = new System.Drawing.Point(47, 35);
            this.txtVonStation.Name = "txtVonStation";
            this.txtVonStation.Size = new System.Drawing.Size(347, 22);
            this.txtVonStation.TabIndex = 0;
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(104, 137);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(33, 17);
            this.lblVon.TabIndex = 15;
            this.lblVon.Text = "Von";
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(388, 137);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(41, 17);
            this.lblNach.TabIndex = 16;
            this.lblNach.Text = "Nach";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Uhrzeit";
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSwitch.BackgroundImage")));
            this.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSwitch.Location = new System.Drawing.Point(329, 157);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(39, 43);
            this.btnSwitch.TabIndex = 19;
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatum.Location = new System.Drawing.Point(97, 261);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerDatum.TabIndex = 22;
            this.dateTimePickerDatum.Value = new System.DateTime(2017, 5, 17, 10, 18, 52, 0);
            // 
            // dateTimePickerUhrzeit
            // 
            this.dateTimePickerUhrzeit.CustomFormat = "HH:mm";
            this.dateTimePickerUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerUhrzeit.Location = new System.Drawing.Point(318, 261);
            this.dateTimePickerUhrzeit.Name = "dateTimePickerUhrzeit";
            this.dateTimePickerUhrzeit.ShowUpDown = true;
            this.dateTimePickerUhrzeit.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerUhrzeit.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(545, 266);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 61);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbVon
            // 
            this.cmbVon.FormattingEnabled = true;
            this.cmbVon.Location = new System.Drawing.Point(97, 165);
            this.cmbVon.Name = "cmbVon";
            this.cmbVon.Size = new System.Drawing.Size(213, 24);
            this.cmbVon.TabIndex = 29;
            this.cmbVon.DropDown += new System.EventHandler(this.cmbVon_DropDown);
            // 
            // cmbNach
            // 
            this.cmbNach.FormattingEnabled = true;
            this.cmbNach.Location = new System.Drawing.Point(391, 165);
            this.cmbNach.Name = "cmbNach";
            this.cmbNach.Size = new System.Drawing.Size(213, 24);
            this.cmbNach.TabIndex = 30;
            this.cmbNach.DropDown += new System.EventHandler(this.cmbNach_DropDown);
            // 
            // btnMapsVon
            // 
            this.btnMapsVon.Image = ((System.Drawing.Image)(resources.GetObject("btnMapsVon.Image")));
            this.btnMapsVon.Location = new System.Drawing.Point(49, 159);
            this.btnMapsVon.Name = "btnMapsVon";
            this.btnMapsVon.Size = new System.Drawing.Size(42, 39);
            this.btnMapsVon.TabIndex = 31;
            this.btnMapsVon.UseVisualStyleBackColor = true;
            this.btnMapsVon.Click += new System.EventHandler(this.btnMapsVon_Click);
            // 
            // btnMapsNach
            // 
            this.btnMapsNach.Image = ((System.Drawing.Image)(resources.GetObject("btnMapsNach.Image")));
            this.btnMapsNach.Location = new System.Drawing.Point(610, 159);
            this.btnMapsNach.Name = "btnMapsNach";
            this.btnMapsNach.Size = new System.Drawing.Size(42, 39);
            this.btnMapsNach.TabIndex = 32;
            this.btnMapsNach.UseVisualStyleBackColor = true;
            this.btnMapsNach.Click += new System.EventHandler(this.btnMapsNach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 748);
            this.Controls.Add(this.btnMapsNach);
            this.Controls.Add(this.btnMapsVon);
            this.Controls.Add(this.cmbNach);
            this.Controls.Add(this.cmbVon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePickerUhrzeit);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNach);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.lblTitel);
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
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchStation;
        private System.Windows.Forms.TextBox txtVonStation;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerUhrzeit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbVon;
        private System.Windows.Forms.ComboBox cmbNach;
        private System.Windows.Forms.Button btnMapsVon;
        private System.Windows.Forms.Button btnMapsNach;
    }
}

